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

            List<Order> orders = OrdersParser.orders;

            int endX = 254;
            int hX = 120;
            int hY = 55;
            int x = 0;
            int y = 0;
            foreach (Order order in orders)
            {
                if(x + 120 > endX)
                {
                    x = 0;
                    y += hY + 20;
                }
                Panel panel = new Panel();
                panel.Size = new Size(hX, hY);
                panel.Location = new Point(x, y);
                panel1.Controls.Add(panel);
                Label label = new Label();
                label.Text = order.phone.name;
                label.Parent = panel;
                label.Location = new Point(0,0);
                label.Size = new Size(120, 13);
                panel.Controls.Add(label);
                Button button = new Button
                {
                    Text = "Подробнее",
                    Tag = order,
                    Size = new Size(114, 30),
                    Location = new Point(3, 20)
                };
                button.Click += aboutButton_Click;
                panel.Controls.Add(button);
                x = x + 5 + hX;
            }
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
