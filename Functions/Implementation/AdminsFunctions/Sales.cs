using System;
using System.Collections.Generic;
using Parser.Repositories;
using Models;
using Models.PhoneClasses;
using System.Windows.Forms;
using BLL.Interfaces;

namespace BLL.Implementation
{
    public class Sales : ISales
    {
        private static ParserSingleton instance = ParserSingleton.GetInstance();

        public Sales() { }

        public bool CreateSale(User user, Phone phone)
        {
            if (user == null)
            {
                MessageBox.Show("Необходимо зарегистрироваться для заказа.");
                return false;
            }
            else
            {
                Order order = new Order(user, phone, DateTime.Now);
                List<Order> orders = instance.ordersParser.entities;
                orders.Add(order);
                instance.ordersParser.writeData(orders);
                MessageBox.Show("Ваш заказ отправлен. Продавец свяжется с Вами по e-mail");
                return true;
            }
        }
    }
}
