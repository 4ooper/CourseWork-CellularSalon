using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Implementation.Validate;
using Parser.Repositories;
using Models.PhoneClasses;
using BLL.Interfaces;
using Models;
using System;

namespace BLL.Implementation
{
    public class Phones : IPhone, IPhoto
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        public Phones() { }
        public bool ChoosePreviewPhoto(OpenFileDialog fileDialog, Button button)
        {
            var opd = fileDialog;
            opd.Multiselect = false;
            var otv = opd.ShowDialog();
            if (otv == DialogResult.OK)
            {
                if (Validation.IsFileImage(opd.FileName))
                {
                    button.Text = opd.FileName;
                    button.Tag = opd.FileName;
                    return true;
                }
                else
                {
                    MessageBox.Show("Выбранный файл не фотография!", "Ошибка");
                    return false;
                }
            }
            return false;
        }

        public bool ChooseMainPhotos(OpenFileDialog fileDialog, Button button)
        {
            var opd = fileDialog;
            opd.Multiselect = true;
            var otv = opd.ShowDialog();
            if (otv == DialogResult.OK)
            {
                if (Validation.IsFilesImages(opd.FileNames))
                {
                    button.Text = $"Выбрано: {opd.FileNames.Count()} файлов";
                    button.Tag = opd.FileNames as string[];
                    return true;
                }
                else
                {
                    MessageBox.Show("Выбранный файл не фотография!", "Ошибка");
                    return false;
                }
            }
            return false;
        }

        public Phone CreatePhone(string name, Button PhotoButton, string price, string screen, string cpu, string memory,
                                string sim, string camera, string battery, string type)
        {
            return new Phone(name.Trim(), $"..\\..\\..\\images\\{name.Trim()}\\small.png", getStringFolders(PhotoButton, name.Trim()),
                             Convert.ToInt32(price), screen, cpu, memory, sim, camera, battery, 
                             instance.phoneTypeParser.entities.Find(item => item.type == type));
        }

        public bool AddPhone(Phone phone)
        {
            Stock stock = new Stock(phone.name, 0);
            return instance.phoneParser.addPhone(phone) && AddPhoneToStock(stock);
        }

        public bool UpdatePhone(Phone prevPhone, Phone phone)
        {
            return instance.phoneParser.updatePhone(prevPhone, phone);
        }

        public bool DeletePhone(Phone phone)
        {
            return instance.phoneParser.deletePhone(phone);
        }

        public string[] getStringFolders(Button choosePhotosButton, string name)
        {
            List<string> strings = new List<string>();

            string[] b = choosePhotosButton.Tag as string[];

            for (int i = 0; i < b.Length; i++)
            {
                strings.Add($"..\\..\\..\\images\\{name}\\Normal\\{i + 1}.png");
            }

            return strings.ToArray();
        }

        public bool AddPhoneToStock(Stock stock)
        {
            List<Stock> stocks = instance.stockParser.entities;
            stocks.Add(stock);
            return instance.stockParser.writeData(stocks);
        }

        public bool AddCountToPhone(Stock stock, int count)
        {
            instance.stockParser.entities[instance.stockParser.entities.FindIndex(item => item.model == stock.model)].count += count;
            List<StockOperation> stockOperations = instance.stockOperationParser.entities;
            stockOperations.Add(new StockOperation("Приход", stock.model, count));
            instance.stockOperationParser.writeData(stockOperations);
            return instance.stockParser.writeData(instance.stockParser.entities);
        }

        public bool SalePhone(Sale sale, Phone phone, User user, Order order = null)
        {
            List<Sale> sales = instance.saleParser.entities;
            sales.Add(sale);
            List<Stock> stocks = instance.stockParser.entities;
            stocks[stocks.FindIndex(item => item.model == phone.name)].count -= 1;
            List<User> users = instance.userParser.entities;
            users[instance.userParser.entities.FindIndex(item => item.name == user.name)].employeesData.salePhones.Add(sale);
            List<StockOperation> stockOperations = instance.stockOperationParser.entities;
            stockOperations.Add(new StockOperation("Расход", phone.name, 1));
            if (order != null)
            {
                return instance.saleParser.writeData(sales) && instance.stockParser.writeData(stocks) && instance.userParser.writeData(users) && RemoveOrder(order) && instance.stockOperationParser.writeData(stockOperations);
            }

            return instance.saleParser.writeData(sales) && instance.stockParser.writeData(stocks) && instance.userParser.writeData(users) && instance.stockOperationParser.writeData(stockOperations);
        }

        public bool RemoveOrder(Order order)
        {
            List<Order> orders = instance.ordersParser.entities;
            orders.RemoveAt(orders.FindIndex(item => item.phone.name == order.phone.name && item.user.name == order.user.name));
            return instance.ordersParser.writeData(orders);
        }
    }
}
