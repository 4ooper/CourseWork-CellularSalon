using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.PhoneClasses;
using Parser;
using Models;

namespace BLL.UIGenerator
{
    public static class UIGenerator
    {
        public static void AddPhones(Panel mainPanel, EventHandler AboutButton_Click, int h = 20)
        {
            List<Phone> phones = PhoneParser.phones;

            int endX = mainPanel.Width;
            int hX = 140;
            int hY = 230;
            int x = 0;
            int y = 0;

            foreach (Phone phone in phones)
            {
                if (x + hX + h > endX)
                {
                    x = 0;
                    y = y + 20 + hY;
                }
                Panel phonePanel = createPanel(hX, hY, x, y);
                mainPanel.Controls.Add(phonePanel);
                PictureBox pictureBox = createPictureBox(phone.smallPhotoURL);
                pictureBox.Parent = phonePanel;
                phonePanel.Controls.Add(pictureBox);
                Label phoneLabel = createLabel(phone.name);
                phoneLabel.Parent = phonePanel;
                phonePanel.Controls.Add(phoneLabel);
                Button phoneButton = CreateButton(phone, AboutButton_Click);
                phonePanel.Controls.Add(phoneButton);
                x = x + h + hX;
            }
        }

        public static void showSales(UserControl form, EventHandler @event)
        {
            List<Sale> sales = SaleParser.sales;

            int endX = 764;
            int hX = 130;
            int hY = 70;
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
                form.Controls.Add(salePanel);
                Label saleLabel = new Label();
                saleLabel.Text = sale.phoneName;
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
                saleButton.Click += @event;
                salePanel.Controls.Add(saleButton);
                x = x + 20 + hX;
            }
        }

        public static void ShowOrders(Panel mainPanel, EventHandler @event, int h = 20)
        {
            List<Order> orders = OrdersParser.orders;

            int endX = mainPanel.Width;
            int hX = 120;
            int hY = 55;
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

        private static Panel createPanel(int hX, int hY, int x, int y)
        {
            Panel phonePanel = new Panel();
            phonePanel.Size = new Size(hX, hY);
            phonePanel.Location = new Point(x, y);
            phonePanel.BackColor = Color.LightGray;
            return phonePanel;
        }

        private static PictureBox createPictureBox(string URlToPhoto)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(URlToPhoto)));
            pictureBox.Width = 140;
            pictureBox.Height = 140;
            pictureBox.Location = new Point(0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            return pictureBox;
        }

        private static Label createLabel(string name)
        {
            Label phoneLabel = new Label();
            phoneLabel.Text = name;
            phoneLabel.Font = new Font("Times New Roman", 10);
            phoneLabel.Location = new Point(3, 150);
            phoneLabel.Size = new Size(133, 19);
            return phoneLabel;
        }

        private static Button CreateButton(Phone phone, EventHandler @event)
        {
            Button phoneButton = new Button();
            phoneButton.Text = "Подробнее";
            phoneButton.BackColor = Color.PaleGreen;
            phoneButton.Size = new Size(75, 23);
            phoneButton.Location = new Point(32, 188);
            phoneButton.Tag = phone;
            phoneButton.Click += @event;
            return phoneButton;
        }
    }
}
