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

namespace CellularSalon.AdminPanels
{
    public partial class AboutPhoneControl : UserControl
    {

        private Phone phone;
        public AboutPhoneControl(Phone phone)
        {
            InitializeComponent();
            this.phone = phone;
            bindFields();
        }

        private void bindFields()
        {
            modelLabel.Text = phone.name;
            priceLabel.Text = phone.totalPrice().ToString();
            screenLabel.Text = phone.features.screen;
            cpuLabel.Text = phone.features.cpu;
            memoryLabel.Text = phone.features.memory;
            batteryLabel.Text = phone.features.battery;
            simLabel.Text = phone.features.sim;
            cameraLabel.Text = phone.features.camera;
            pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[0])));
            countLabel.Text = phone.count.ToString();
        }

        private void nextPicButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pictureBox1.Tag) + 1 < phone.normalPhotoURL.Count())
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[Convert.ToInt32(pictureBox1.Tag) + 1])));
                pictureBox1.Tag = Convert.ToInt32(pictureBox1.Tag) + 1;
            }
            else
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[0])));
                pictureBox1.Tag = 0;
            }
        }

        private void PrevPIcButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pictureBox1.Tag) - 1 >= 0)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[Convert.ToInt32(pictureBox1.Tag) - 1])));
                pictureBox1.Tag = Convert.ToInt32(pictureBox1.Tag) - 1;
            }
            else
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[phone.normalPhotoURL.Count() - 1])));
                pictureBox1.Tag = phone.normalPhotoURL.Count() - 1;
            }
        }
    }
}
