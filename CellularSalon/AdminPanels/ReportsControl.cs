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

namespace CellularSalon.AdminPanels
{
    public partial class ReportsControl : UserControl
    {
        private List<Sale> sales;

        public ReportsControl()
        {
            InitializeComponent();
            this.sales = SaleParser.sales;
            showSales();
        }
        
        private void showSales()
        {
            int endX = 764;
            int hX = 150;
            int hY = 120;
            int x = 0;
            int y = 0;
            foreach (Sale sale in sales)
            {
                if (x + hX + 20 > endX)
                {
                    x = 0;
                    y = y + 50 + hY;
                }
                Panel salePanel = new Panel();
                salePanel.Size = new Size(hX, hY);
                salePanel.Location = new Point(x, y);
                salePanel.BackColor = Color.LightGray;
                this.Controls.Add(salePanel);
                Label saleLabel = new Label();
                saleLabel.Text = sale.phone.name;
                saleLabel.Font = new Font("Times New Roman", 10);
                saleLabel.Parent = salePanel;
                saleLabel.Location = new Point(0, 0);
                saleLabel.Size = new Size(hX, 20);
                salePanel.Controls.Add(saleLabel);
                Button saleButton = new Button();
                saleButton.Text = "Отчёт";
                saleButton.BackColor = Color.PaleGreen;
                saleButton.Size = new Size(hX, 35);
                saleButton.Location = new Point(0, 30);
                saleButton.Parent = salePanel;
                saleButton.Tag = sale.linkToHtml;
                saleButton.Click += reportButton_Click;
                salePanel.Controls.Add(saleButton);
                x = x + 20 + hX;
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string link = (sender as Button).Tag as string;
            System.Diagnostics.Process.Start(link);
        }
    }
}
