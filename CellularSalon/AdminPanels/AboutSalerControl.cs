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

namespace CellularSalon.AdminPanels
{
    public partial class AboutSalerControl : UserControl
    {
        private User user;
        public AboutSalerControl(string name)
        {
            InitializeComponent();
            this.user = UserParser.employees.Where(item => item.name == name).Select(item => item).ToList()[0];
            nameLabel.Text = name;
            comboBox1.DataSource = user.employeesData.salePhones.Select(item => item.phone.name).ToList();
            countOfSalePhonesLabel.Text = $"Количество проданных телефонов: {user.employeesData.salePhones.Count()}";
            priceOfSaleLabel.Text = $"Сумма средств с продаж: {user.employeesData.totalSalePrice()}";
        }

        private void AboutSalerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
