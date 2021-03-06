using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Models.PhoneClasses;
using BLL.CarouselPicture;
using Parser.Repositories;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер вывода информации о телефоне в админ-панеле
    /// </summary>
    public partial class AboutPhoneControl : UserControl
    {

        private Phone phone;
        private ParserSingleton instance = ParserSingleton.GetInstance();
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
            countLabel.Text = instance.stockParser.entities.Find(item => item.model == phone.name).count.ToString();
        }

        private void nextPicButton_Click(object sender, EventArgs e)
        {
            Carousel.PicButtonClick(this.pictureBox1, phone, true);
        }

        private void PrevPIcButton_Click(object sender, EventArgs e)
        {
            Carousel.PicButtonClick(this.pictureBox1, phone, false);
        }
    }
}
