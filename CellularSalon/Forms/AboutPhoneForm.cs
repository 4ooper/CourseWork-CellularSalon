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
using Models;
using Parser;
using BLL.AboutPhoneForm;
using BLL.CarouselPicture;

namespace CellularSalon.Forms
{
    public partial class AboutPhoneForm : Form
    {
        private Phone phone;
        private User user;
        public AboutPhoneForm(Form form, Phone item, User user = null)
        {
            InitializeComponent();
            form.Hide();
            phone = item;
            this.user = user;
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
            createSaleButton.Enabled = phone.count > 0 ? true : false;
            if (createSaleButton.Enabled == false)
            {
                createSaleButton.Text = "Товара нет в наличии!";
            }
        }

        private void NextPicButton_Click(object sender, EventArgs e)
        {
            Carousel.PicButtonClick(this.pictureBox1, phone, true);
        }

        private void PrevPicButton_Click(object sender, EventArgs e)
        {
            Carousel.PicButtonClick(this.pictureBox1, phone, false);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MainForm(this, user).Show();
        }

        private void createSaleButton_Click(object sender, EventArgs e)
        {
            if (AboutPhoneBLL.CreateSale(user, phone))
            {
                new MainForm(this, user).Show();
            }
            else
            {
                new RegisterForm(this).Show();
            }
        }
    }
}
