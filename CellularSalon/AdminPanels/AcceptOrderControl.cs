using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser;
using Models;
using Models.PhoneClasses;

namespace CellularSalon.AdminPanels
{
    public partial class AcceptOrderControl : UserControl
    {
        private User adminUser;
        private Order order;
        private Phone phone
        {
            get
            {
                return PhoneParser.phones.Where(item => item.name == order.phone.name).ToList()[0];
            }
        }
        private User client
        {
            get
            {
                return order.user;
            }
        }

        public AcceptOrderControl(User user, Order order)
        {
            InitializeComponent();
            this.order = order;
            this.adminUser = user;
            bindGrid();
        }

        private void bindGrid()
        {
            userLabel.Text = $"Покупатель: {client.name}";
            priceLabel.Text = $"Цена: {phone.totalPrice()}";
            countLabel.Text = $"Количество: {phone.count}";
            modelLabel.Text = $"Модель: {phone.name}";
            acceptButton.Enabled = phone.count != 0;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale(phone.name, client.email, adminUser.email, phone.totalPrice());
            List<Sale> sales = SaleParser.sales;
            sales.Add(sale);
            SaleParser.writeData(sales);
            List<Phone> phones = PhoneParser.phones;
            phones[phones.FindIndex(item => item.name == order.phone.name)].count -= 1;
            PhoneParser.writeData(phones);
            List<Order> orders = OrdersParser.orders;
            orders.RemoveAt(orders.FindIndex(item => item.phone.name == order.phone.name && item.user.name == order.user.name));
            OrdersParser.writeNotes(orders);
            List<User> users = UserParser.employees;
            users[UserParser.employees.FindIndex(item => item.name == adminUser.name)].employeesData.salePhones.Add(sale);
            UserParser.writeData(users);
            MessageBox.Show("Продажа записана!");
            this.Hide();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            List<Order> orders = OrdersParser.orders;
            orders.RemoveAt(orders.FindIndex(item => item.phone.name == order.phone.name && item.user.name == order.user.name));
            OrdersParser.writeNotes(orders);
            MessageBox.Show("Заказ удалён!");
            this.Hide();

        }
    }
}
