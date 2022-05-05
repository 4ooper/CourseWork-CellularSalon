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
using BLL.ValidationEnterData;
using BLL.CarouselPicture;
using BLL.AdminPanel;
using BLL.FoldersBLL;

namespace CellularSalon.AdminPanels
{
    public partial class changePhoneDataControl : UserControl
    {
        private Phone incomePhone;

        public changePhoneDataControl(Phone item)
        {
            InitializeComponent();
            incomePhone = item;
            bindFields();
        }

        private void bindFields()
        {
            nameBox.Text = incomePhone.name;
            screenBox.Text = incomePhone.features.screen;
            cpuBox.Text = incomePhone.features.cpu;
            memoryBox.Text = incomePhone.features.memory;
            accumBox.Text = incomePhone.features.battery;
            cameraBox.Text = incomePhone.features.camera;
            priceBox.Text = incomePhone.standartPrice.ToString();
            previewButton.Tag = incomePhone.smallPhotoURL;
            mainPhotoButton.Tag = incomePhone.normalPhotoURL;
            pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(incomePhone.normalPhotoURL[0])));
            typeBox.DataSource = new string[] { "Смартфон", "Фичерфон" };
            typeBox.SelectedItem = incomePhone.type;
            simBox.DataSource = new string[] { "Nano", "Micro", "Standart" };
            simBox.SelectedItem = incomePhone.features.sim;
        }

        private void checkInputs()
        {
            if (nameBox.Text.Count() > 0 && priceBox.Text.Count() > 0 &&
                screenBox.Text.Count() > 0 && cpuBox.Text.Count() > 0 && memoryBox.Text.Count() > 0 &&
                cameraBox.Text.Count() > 0 && accumBox.Text.Count() > 0 &&
                Validation.IsInt(priceBox.Text) && previewButton.Tag != null && mainPhotoButton.Tag != null)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void NextPhotoButton_Click(object sender, EventArgs e)
        {
            Carousel.PicButtonClick(pictureBox1, incomePhone, true);
        }

        private void PrevPhotoButton_Click(object sender, EventArgs e)
        {
            Carousel.PicButtonClick(pictureBox1, incomePhone, false);
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            if(PhoneData.ChoosePreviewPhoto(photoFileDialog, sender as Button))
            {
                MessageBox.Show("Файл выбран успешно!", "Успех!");
            }
            else
            {
                MessageBox.Show("Ничего не выбрано!", "Предупреждение");
            }
            checkInputs();
        }

        private void mainPhotoButton_Click(object sender, EventArgs e)
        {
            if (PhoneData.ChooseMainPhotos(photoFileDialog, sender as Button))
            {
                MessageBox.Show("Файл выбран успешно!", "Успех!");
            }
            else
            {
                MessageBox.Show("Ничего не выбрано!", "Предупреждение");
            }
            checkInputs();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Folders.CreateTempFolders(mainPhotoButton, previewButton, nameBox.Text);
            Folders.deleteFolders(incomePhone.name);
            Folders.moveFromTmp(nameBox.Text);

            Phone phone = new Phone(nameBox.Text, $"..\\..\\..\\images\\{nameBox.Text}\\small.png",
                PhoneData.getStringFolders(mainPhotoButton, nameBox.Text), incomePhone.count, Convert.ToInt32(priceBox.Text), screenBox.Text, cpuBox.Text, memoryBox.Text,
                simBox.Text, cameraBox.Text, accumBox.Text, typeBox.Text);

            if(PhoneData.UpdatePhone(incomePhone, phone))
            {
                MessageBox.Show("Выполнено!");
            }
            else
            {
                MessageBox.Show("Что то пошло не так!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Folders.deleteFolders(incomePhone.name);
            if (PhoneData.DeletePhone(incomePhone))
            {
                MessageBox.Show("Выполнено!");
            }
            else
            {
                MessageBox.Show("Что то пошло не так!");
            }
        }
    }
}
