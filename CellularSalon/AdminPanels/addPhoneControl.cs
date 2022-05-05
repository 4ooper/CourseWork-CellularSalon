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
using BLL.AdminPanel;
using BLL.ValidationEnterData;
using BLL.FoldersBLL;

namespace CellularSalon.AdminPanels
{
    public partial class addPhoneControl : UserControl
    {
        public addPhoneControl()
        {
            InitializeComponent();
            typeBox.DataSource = new string[] { "Смартфон", "Фичерфон" };
            typeBox.SelectedIndex = 0;
            simBox.DataSource = new string[] { "Nano", "Micro", "Standart" };
            simBox.SelectedIndex = 0;
            saveButton.Enabled = false;
            choosePhotoButton.Tag = null;
            choosePreviewButton.Tag = null;
        }

        private void choosePreviewButton_Click(object sender, EventArgs e)
        {
            if(PhoneData.ChoosePreviewPhoto(previewFileDialog, sender as Button))
            {
                MessageBox.Show("Файл выбран успешно!", "Успех!");
            }
            else
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка");
            }
            checkInputs();
        }

        private void choosePhotoButton_Click(object sender, EventArgs e)
        {
            if (PhoneData.ChooseMainPhotos(previewFileDialog, sender as Button))
            {
                MessageBox.Show("Файлы выбраны успешно!", "Успех!");
            }
            else
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка");
            }
            checkInputs();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Folders.CreateFolders(choosePhotoButton, choosePreviewButton, nameBox.Text);

            Phone phone = new Phone(nameBox.Text, $"..\\..\\..\\images\\{nameBox.Text}\\small.png",
                PhoneData.getStringFolders(choosePhotoButton, nameBox.Text), 
                Convert.ToInt32(countBox.Text), Convert.ToInt32(priceBox.Text), screenBox.Text, cpuBox.Text, memoryBox.Text,
                simBox.Text, cameraBox.Text, batteryBox.Text, typeBox.Text);

            if (PhoneData.CreatePhone(phone))
            {
                MessageBox.Show("Телефон добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void inputTextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void checkInputs()
        {
            if (nameBox.Text.Count() > 0 && countBox.Text.Count() > 0 && priceBox.Text.Count() > 0 &&
                screenBox.Text.Count() > 0 && cpuBox.Text.Count() > 0 && memoryBox.Text.Count() > 0 &&
                cameraBox.Text.Count() > 0 && batteryBox.Text.Count() > 0 && Validation.IsInt(countBox.Text) &&
                Validation.IsInt(priceBox.Text) && choosePreviewButton.Tag != null && choosePhotoButton.Tag != null)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
    }
}
