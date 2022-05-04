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

namespace CellularSalon.AdminPanels
{
    public partial class FindSalerControl : UserControl
    {
        public FindSalerControl()
        {
            InitializeComponent();
            comboBox1.DataSource = UserParser.employees.Where(item => item.position == "Продавец").Select(item => item.name).ToList();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AboutSalerControl(comboBox1.SelectedItem.ToString()));
        }
    }
}
