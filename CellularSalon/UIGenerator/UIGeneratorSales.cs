using System;
using System.Collections.Generic;
using Parser.Repositories;
using Models;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace CellularSalon.UIGenerator
{
    /// <summary>
    /// Генератор списка отчёта продаж
    /// </summary>
    public class UIGeneratorSales
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        private UserControl mainPanel;
        private EventHandler @event;
        private int h;
        private int hX;
        private int hY;

        public UIGeneratorSales(UserControl mainPanel, EventHandler @event, int h, int hX, int hY)
        {
            this.mainPanel = mainPanel;
            this.@event = @event;
            this.h = h;
            this.hX = hX;
            this.hY = hY;
        }
        public void Generate()
        {
            List<Sale> sales = instance.saleParser.entities;

            int endX = mainPanel.Width;
            int x = 0;
            int y = 0;
            foreach (Sale sale in sales)
            {
                if (x + hX + 20 > endX)
                {
                    x = 0;
                    y = y + 50 + hY;
                }
                Panel salePanel = CreatePanel(hX, hY, x, y);
                salePanel.Parent = mainPanel;
                mainPanel.Controls.Add(salePanel);
                Label saleLabel = CreateLabel(sale.phoneName);
                saleLabel.Parent = salePanel;
                salePanel.Controls.Add(saleLabel);
                Button saleButton = CreateButton(sale, @event);
                saleButton.Parent = salePanel;
                salePanel.Controls.Add(saleButton);
                x = x + 50 + hX;
            }
        }

        private Panel CreatePanel(int hX, int hY, int x, int y)
        {
            Panel phonePanel = new Panel();
            phonePanel.Size = new Size(hX, hY);
            phonePanel.Location = new Point(x, y);
            phonePanel.BackColor = Color.LightGray;
            phonePanel.BorderStyle = BorderStyle.FixedSingle;
            return phonePanel;
        }

        private Label CreateLabel(string name)
        {
            Label phoneLabel = new Label();
            phoneLabel.Text = name;
            phoneLabel.Font = new Font("Times New Roman", 10);
            phoneLabel.Location = new Point(0, 0);
            phoneLabel.Size = new Size(hX, 20);
            return phoneLabel;
        }

        private Button CreateButton(Sale sale, EventHandler @event)
        {
            Button button = new Button();
            button.BackColor = Color.PaleGreen;
            button.Size = new Size(hX - 3, 35);
            button.Text = "Отчёт";
            button.Margin = Padding.Empty;
            button.Location = new Point(0, 30);
            button.Tag = sale.linkToHtml;
            button.Click += @event;
            return button;
        }
    }
}
