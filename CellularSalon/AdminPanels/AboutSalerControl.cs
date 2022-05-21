using System.Data;
using System.Linq;
using System.Windows.Forms;
using Parser.Repositories;
using Models;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер информации о продавце
    /// </summary>
    public partial class AboutSalerControl : UserControl
    {
        private User user;
        private static ParserSingleton instance = ParserSingleton.GetInstance();
        public AboutSalerControl(string name)
        {
            InitializeComponent();
            this.user = instance.userParser.entities.Where(item => item.name == name).Select(item => item).ToList()[0];
            nameLabel.Text = name;
            comboBox1.DataSource = user.employeesData.salePhones.Select(item => item.phoneName).ToList();
            countOfSalePhonesLabel.Text = $"Количество проданных телефонов: {user.employeesData.salePhones.Count()}";
            priceOfSaleLabel.Text = $"Сумма средств с продаж: {user.employeesData.totalSalePrice()}";
        }
    }
}
