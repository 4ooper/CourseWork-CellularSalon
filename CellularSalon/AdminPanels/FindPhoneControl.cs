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
using Models.PhoneClasses;

namespace CellularSalon.AdminPanels
{
    public partial class FindPhoneControl : UserControl
    {
        public FindPhoneControl()
        {
            InitializeComponent();
            namesBox.DataSource = PhoneParser.models;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Phone phone = PhoneParser.phones.Where(item => item.name == namesBox.Text).ToList()[0];
            panel1.Controls.Clear();
            panel1.Controls.Add(new changePhoneDataControl(phone));
        }
    }
}
