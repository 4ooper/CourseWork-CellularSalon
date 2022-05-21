using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Parser.Repositories;
using Models;
using Models.PhoneClasses;
using BLL.Implementation;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер управления активными заказами
    /// </summary>
    public partial class AcceptOrderControl : UserControl
    {
        private User adminUser;
        private Order order;
        private int count;

        private Phones phoneFun = new Phones();
        private ParserSingleton instance = ParserSingleton.GetInstance();
        private Phone phone
        {
            get
            {
                return instance.phoneParser.entities.Where(item => item.name == order.phone.name).ToList()[0];
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
            this.count = instance.stockParser.entities.Find(item => item.model == order.phone.name).count;
            bindGrid();
        }

        private void bindGrid()
        {
            userLabel.Text = $"Покупатель: {client.name}";
            priceLabel.Text = $"Цена: {phone.totalPrice()}";
            countLabel.Text = $"Количество: {count}";
            modelLabel.Text = $"Модель: {phone.name}";
            acceptButton.Enabled = count != 0;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale(phone.name, client.email, adminUser.email, phone.totalPrice());
            if(phoneFun.SalePhone(sale, phone, adminUser, order))
            {
                MessageBox.Show("Продажа записана!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка! Заказ не одобрен!");
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            if (phoneFun.RemoveOrder(order))
            {
                MessageBox.Show("Заказ удалён!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
