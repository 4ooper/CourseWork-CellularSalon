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
    public partial class SaleControl : UserControl
    {
        private User user;
        public SaleControl(User user)
        {
            InitializeComponent();
            this.user = user;
            usersBox.DataSource = UserParser.employees.Where(item => item.name != user.name).Select(item => item.name).ToList();
            phonesBox.DataSource = PhoneParser.phones.Where(item => item.count > 0).Select(item => item.name).ToList();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            Phone phone = PhoneParser.phones.First(item => item.name == phonesBox.SelectedItem.ToString());
            User client = UserParser.employees.First(item => item.name == usersBox.SelectedItem.ToString());
            Sale sale = new Sale(phone, client, user);
            List<Sale> sales = SaleParser.sales;
            sales.Add(sale);
            SaleParser.writeData(sales);
            List<Phone> phones = PhoneParser.phones;
            phones[phones.FindIndex(item => item.name == phone.name)].count -= 1;
            PhoneParser.writeData(phones);
            List<User> users = UserParser.employees;
            users[UserParser.employees.FindIndex(item => item.name == user.name)].employeesData.salePhones.Add(sale);
            UserParser.writeData(users);
            MessageBox.Show("Продажа записана!");
            this.Hide();
        }
    }
}
