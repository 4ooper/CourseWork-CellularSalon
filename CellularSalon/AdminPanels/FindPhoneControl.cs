using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Parser.Repositories;
using Models.PhoneClasses;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллера для поиска телефона по модели
    /// </summary>
    public partial class FindPhoneControl : UserControl
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        public FindPhoneControl()
        {
            InitializeComponent();
            namesBox.DataSource = instance.phoneParser.models;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Phone phone = instance.phoneParser.entities.Where(item => item.name == namesBox.Text).ToList()[0];
            panel1.Controls.Clear();
            panel1.Controls.Add(new changePhoneDataControl(phone));
        }
    }
}
