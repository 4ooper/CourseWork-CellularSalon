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
using Models.PhoneClasses;
using BLL.UIGenerator;

namespace CellularSalon.AdminPanels
{
    public partial class OrderControl : UserControl
    {
        private User admin;
        public OrderControl(User user)
        {
            InitializeComponent();
            admin = user;
            showOrders();
        }

        private void showOrders()
        {
            panel1.Controls.Clear();
            UIGenerator.ShowOrders(this.panel1, aboutButton_Click);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AcceptOrderControl(admin, (Order)(sender as Button).Tag));
        }
        private void updateOrders_Click(object sender, EventArgs e)
        {
            UIGenerator.ShowOrders(this.panel1, aboutButton_Click);
        }
    }
}
