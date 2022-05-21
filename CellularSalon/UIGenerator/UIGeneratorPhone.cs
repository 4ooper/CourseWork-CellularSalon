using System;
using System.Collections.Generic;
using Parser.Repositories;
using Models.PhoneClasses;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace CellularSalon.UIGenerator
{
    /// <summary>
    /// Генератор списка телефонов
    /// </summary>
    public class UIGeneratorPhone : IUIGenerator
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        private Panel mainPanel;
        private EventHandler @event;
        private int h;
        private int hX;
        private int hY;
        public UIGeneratorPhone(Panel mainPanel, EventHandler @event, int h, int hX, int hY)
        {
            this.mainPanel = mainPanel;
            this.@event = @event;
            this.h = h;
            this.hX = hX;
            this.hY = hY;
        }
        public void Generate()
        {
            List<Phone> phones = instance.phoneParser.entities;

            int endX = mainPanel.Width;
            int x = 0;
            int y = 0;

            foreach (Phone phone in phones)
            {
                if (x + hX + h > endX)
                {
                    x = 0;
                    y = y + 10 + hY;
                }
                Panel phonePanel = CreatePanel(hX, hY, x, y);
                mainPanel.Controls.Add(phonePanel);
                PictureBox pictureBox = CreatePictureBox(phone.smallPhotoURL);
                pictureBox.Parent = phonePanel;
                phonePanel.Controls.Add(pictureBox);
                Label phoneLabel = CreateLabel(phone.name);
                phoneLabel.Parent = phonePanel;
                phonePanel.Controls.Add(phoneLabel);
                Button phoneButton = CreateButton(phone, @event);
                phonePanel.Controls.Add(phoneButton);
                x = x + h + hX;
            }
        }

        private Panel CreatePanel(int hX, int hY, int x, int y)
        {
            Panel phonePanel = new Panel();
            phonePanel.Size = new Size(hX, hY);
            phonePanel.Location = new Point(x, y);
            phonePanel.BackColor = Color.FromArgb(121, 203, 184);
            phonePanel.BorderStyle = BorderStyle.FixedSingle;
            return phonePanel;
        }

        private PictureBox CreatePictureBox(string URlToPhoto)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(URlToPhoto)));
            pictureBox.Width = 140;
            pictureBox.Height = 140;
            pictureBox.Location = new Point(0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            return pictureBox;
        }

        private Label CreateLabel(string name)
        {
            Label phoneLabel = new Label();
            phoneLabel.Text = name;
            phoneLabel.Font = new Font("Yu Gothic U", 10);
            phoneLabel.ForeColor = Color.FromArgb(80, 4, 116);
            phoneLabel.Location = new Point(3, 150);
            phoneLabel.Size = new Size(133, 19);
            return phoneLabel;
        }

        private Button CreateButton(Phone phone, EventHandler @event)
        {
            Button phoneButton = new Button();
            phoneButton.Text = "Подробнее";
            phoneButton.BackColor = Color.FromArgb(80, 4, 116);
            phoneButton.ForeColor = Color.FromArgb(121, 203, 184);
            phoneButton.Size = new Size(75, 23);
            phoneButton.Location = new Point(32, 188);
            phoneButton.Tag = phone;
            phoneButton.Click += @event;
            return phoneButton;
        }
    }
}
