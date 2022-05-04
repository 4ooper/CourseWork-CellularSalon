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
using Models;
using Parser;

namespace CellularSalon.Forms
{
    public partial class AboutPhoneForm : Form
    {
        private Models.PhoneClasses.Phone phone;
        private User user;
        public AboutPhoneForm(Form form, Models.PhoneClasses.Phone item, User user = null)
        {
            InitializeComponent();
            form.Hide();
            phone = item;
            this.user = user;
            bindFields();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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
            if(createSaleButton.Enabled == false)
            {
                createSaleButton.Text = "Товара нет в наличии!";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MainForm(this, user).Show();
        }

        private void createSaleButton_Click(object sender, EventArgs e)
        {
            if(user == null)
            {
                MessageBox.Show("Необходимо зарегистрироваться для заказа.");
                new RegisterForm(this).Show();
            }
            else
            {
                Order order = new Order(user, phone, DateTime.Now);
                OrdersParser.createNode(order);
                MessageBox.Show("Ваш заказ отправлен. Продавец свяжется с Вами по e-mail");
                new MainForm(this, user).Show();
            }
        }
    }
}
