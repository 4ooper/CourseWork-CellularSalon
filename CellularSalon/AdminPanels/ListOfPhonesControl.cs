using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.PhoneClasses;
using Parser;
using BLL.UIGenerator;

namespace CellularSalon.AdminPanels
{
    public partial class ListOfPhonesControl : UserControl
    {
        public ListOfPhonesControl()
        {
            InitializeComponent();
            UIGenerator.AddPhones(this.panel1, aboutButton_Click, 5);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AboutPhoneControl((sender as Button).Tag as Phone));
        }
    }
}
