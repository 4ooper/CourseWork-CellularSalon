using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Models.PhoneClasses;
using Models;
using BLL.CarouselPicture;
using BLL.Implementation;
using Parser.Repositories;

namespace CellularSalon.Forms
{
    /// <summary>
    /// Окно приложение, показывающее основную информацию о телефоне
    /// </summary>
    public partial class AboutPhoneForm : Form
    {
        private Phone phone;
        private User user;

        private Sales sales = new Sales();

        private ParserSingleton instance = ParserSingleton.GetInstance();
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
            createSaleButton.Enabled = instance.stockParser.entities.Find(item => item.model == phone.name).count > 0 ? true : false;
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
            if (sales.CreateSale(user, phone))
            {
                new MainForm(this, user).Show();
            }
            else
            {
                new RegisterForm(this).Show();
            }
        }

        private void AboutPhoneForm_Load(object sender, EventArgs e)
        {

        }
    }
}
