using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Parser;
using BLL.UIGenerator;

namespace CellularSalon.AdminPanels
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
            UIGenerator.showSales(this, reportButton_Click);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string link = (sender as Button).Tag as string;
            System.Diagnostics.Process.Start(link);
        }
    }
}
