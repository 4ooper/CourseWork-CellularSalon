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
    /// Контроллер продажи телефона
    /// </summary>
    public partial class SaleControl : UserControl
    {
        private User user;
        private Phones phonesFun = new Phones();

        private ParserSingleton instance = ParserSingleton.GetInstance();
        public SaleControl(User user)
        {
            InitializeComponent();
            this.user = user;
            usersBox.DataSource = instance.userParser.entities.Where(item => item.name != user.name).Select(item => item.name).ToList();
            phonesBox.DataSource = instance.stockParser.entities.Where(item => item.count > 0).Select(item => item.model).ToList();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            Phone phone = instance.phoneParser.entities.First(item => item.name == phonesBox.SelectedItem.ToString());
            User client = instance.userParser.entities.First(item => item.name == usersBox.SelectedItem.ToString());
            Sale sale = new Sale(phone.name, client.email, user.email, phone.totalPrice());
            if(phonesFun.SalePhone(sale, phone, user))
            {
                MessageBox.Show("Продажа записана!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка! Продажа невозможна");
            }
        }
    }
}
