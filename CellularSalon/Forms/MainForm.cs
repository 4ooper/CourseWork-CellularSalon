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
using Models.PhoneClasses;
using Parser;
using Functions;
using System.IO;

namespace CellularSalon.Forms
{
    public partial class MainForm : Form
    {
        private User user;
        public MainForm(Form form, User item = null)
        {
            InitializeComponent();
            bindUser(item);
            user = item;
            form.Hide();
            addPhones();
        }

        private void bindUser(User item = null)
        {
            if (item != null)
            {
                userName.Text = item.name;
                userPosition.Text = item.position;
                adminPanelButton.Visible = false;
                if (item.employeesData != null)
                {
                    adminPanelButton.Visible = item.employeesData.canUseAdminPanel;
                }
                
            }
            else
            {
                userName.Text = "Гость";
                userPosition.Visible = false;
                adminPanelButton.Visible = false;
            }
        }

        private void addPhones()
        {
            List<Phone> phones = PhoneParser.phones;

            int endX = 570;
            int hX= 60;
            int hY = 30;
            int x = 0;
            int y = 0;
            foreach (Phone phone in phones)
            {
                if(x + 140 > endX)
                {
                    x = 0;
                    y = y + 230 + hY;
                }
                Panel phonePanel = new Panel();
                phonePanel.Size = new Size(140, 230);
                phonePanel.Location = new Point(x, y);
                phonePanel.BackColor = Color.LightGray;
                mainPanel.Controls.Add(phonePanel);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Parent = phonePanel;
                pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.smallPhotoURL)));
                pictureBox.Width = 140;
                pictureBox.Height = 140;
                pictureBox.Location = new Point(0, 0);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                phonePanel.Controls.Add(pictureBox);
                Label phoneLabel = new Label();
                phoneLabel.Text = phone.name;
                phoneLabel.Font = new Font("Times New Roman", 10);
                phoneLabel.Parent = phonePanel;
                phoneLabel.Location = new Point(3, 150);
                phoneLabel.Size = new Size(133, 19);
                phonePanel.Controls.Add(phoneLabel);
                Button phoneButton = new Button();
                phoneButton.Text = "Подробнее";
                phoneButton.BackColor = Color.PaleGreen;
                phoneButton.Size = new Size(75, 23);
                phoneButton.Location = new Point(32, 188);
                phoneButton.Tag = phone;
                phoneButton.Click += aboutButton_Click;
                phonePanel.Controls.Add(phoneButton);
                x = x + 140 + hX;
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            new AboutPhoneForm(this, (Phone)(sender as Button).Tag, user == null ? null : user).Show();
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            new adminPanelForm(this, user).Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.user = null;
            new authForm().Show();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
