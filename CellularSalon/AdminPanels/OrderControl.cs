using System;
using System.Windows.Forms;
using Models;
using CellularSalon.UIGenerator;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер отображения списка заказов
    /// </summary>
    public partial class OrderControl : UserControl
    {
        private User admin;
        private UIGeneratorOrders UIGenerator;
        public OrderControl(User user)
        {
            InitializeComponent();
            admin = user;
            UIGenerator = new UIGeneratorOrders(this.panel1, aboutButton_Click, 20, 120, 55);
            showOrders();
        }

        private void showOrders()
        {
            panel1.Controls.Clear();
            UIGenerator.Generate();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AcceptOrderControl(admin, (Order)(sender as Button).Tag));
        }
        private void updateOrders_Click(object sender, EventArgs e)
        {
            showOrders();
        }
    }
}
