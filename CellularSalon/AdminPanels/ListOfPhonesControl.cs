using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.PhoneClasses;
using Parser;

namespace CellularSalon.AdminPanels
{
    public partial class ListOfPhonesControl : UserControl
    {
        public ListOfPhonesControl()
        {
            InitializeComponent();
            showPhones();
        }

        private void showPhones()
        {
            List<Phone> phones = PhoneParser.phones;

            int endX = 304;
            int hX = 150;
            int hY = 109;
            int x = 0;
            int y = 0;
            foreach (Phone phone in phones)
            {
                if (x + hX > endX)
                {
                    x = 0;
                    y = y + 20 + hY;
                }
                Panel phonePanel = new Panel();
                phonePanel.Size = new Size(hX, hY);
                phonePanel.Location = new Point(x, y);
                phonePanel.BackColor = Color.LightGray;
                panel1.Controls.Add(phonePanel);
                Label phoneLabel = new Label();
                phoneLabel.Text = phone.name;
                phoneLabel.Font = new Font("Times New Roman", 12);
                phoneLabel.Parent = phonePanel;
                phoneLabel.Location = new Point(3, 9);
                phoneLabel.Size = new Size(144, 19);
                phonePanel.Controls.Add(phoneLabel);
                Button phoneButton = new Button();
                phoneButton.Text = "Подробнее";
                phoneButton.BackColor = Color.PaleGreen;
                phoneButton.Size = new Size(144, 38);
                phoneButton.Location = new Point(3, 68);
                phoneButton.Tag = phone;
                phoneButton.Click += aboutButton_Click;
                phonePanel.Controls.Add(phoneButton);
                x = x + 4 + hX;
            }
        }
        
        private void aboutButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AboutPhoneControl((sender as Button).Tag as Phone));
        }
    }
}
