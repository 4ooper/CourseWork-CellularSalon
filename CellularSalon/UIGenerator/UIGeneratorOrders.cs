using System;
using System.Collections.Generic;
using Parser.Repositories;
using Models;
using System.Windows.Forms;
using System.Drawing;

namespace CellularSalon.UIGenerator
{
    /// <summary>
    /// Генератор заказов
    /// </summary>
    public class UIGeneratorOrders : IUIGenerator
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        private Panel mainPanel;
        private EventHandler @event;
        private int h;
        private int hX;
        private int hY;

        public UIGeneratorOrders(Panel mainPanel, EventHandler @event, int h, int hX, int hY)
        {
            this.mainPanel = mainPanel;
            this.@event = @event;
            this.h = h;
            this.hX = hX;
            this.hY = hY;
        }

        public void Generate()
        {
            List<Order> orders = instance.ordersParser.entities;

            int endX = mainPanel.Width;
            int x = 0;
            int y = 0;
            foreach (Order order in orders)
            {
                if (x + hX + h > endX)
                {
                    x = 0;
                    y += hY + 20;
                }
                Panel panel = new Panel();
                panel.Size = new Size(hX, hY);
                panel.Location = new Point(x, y);
                mainPanel.Controls.Add(panel);
                Label label = new Label();
                label.Text = order.phone.name;
                label.Parent = panel;
                label.Location = new Point(0, 0);
                label.Size = new Size(120, 13);
                panel.Controls.Add(label);
                Button button = new Button
                {
                    Text = "Подробнее",
                    Tag = order,
                    Size = new Size(114, 30),
                    Location = new Point(3, 20)
                };
                button.Click += @event;
                panel.Controls.Add(button);
                x = x + h + hX;
            }
        }
    }
}
