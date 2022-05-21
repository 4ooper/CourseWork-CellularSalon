using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Parser.Repositories;
using Models;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер для поиска пользователя и вывода информации о пользователе
    /// </summary>
    public partial class FindUserControl : UserControl
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        public FindUserControl()
        {
            InitializeComponent();
            findNameBox.DataSource = instance.userParser.entities.Select(item => item.name).ToList();
        }

        private void findNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            findemailBox.DataSource = instance.userParser.entities.Where(item => item.name == findNameBox.Text).Select(item => item.email).ToList();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            User findUser = instance.userParser.entities.Where(item => item.name == findNameBox.Text && item.email == findemailBox.Text).ToList()[0];
            panel1.Controls.Clear();
            panel1.Controls.Add(new changeUserDataControl(findUser));
        }
    }
}
    