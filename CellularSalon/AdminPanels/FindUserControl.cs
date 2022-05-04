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
    public partial class FindUserControl : UserControl
    {
        public FindUserControl()
        {
            InitializeComponent();
            findNameBox.DataSource = UserParser.employees.Select(item => item.name).ToList();
        }

        private void findNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            findemailBox.DataSource = UserParser.employees.Where(item => item.name == findNameBox.Text).Select(item => item.email).ToList();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            User findUser = UserParser.employees.Where(item => item.name == findNameBox.Text && item.email == findemailBox.Text).ToList()[0];
            panel1.Controls.Clear();
            panel1.Controls.Add(new changeUserDataControl(findUser));
        }
    }
}
    