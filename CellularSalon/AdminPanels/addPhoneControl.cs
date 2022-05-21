using System;
using System.Linq;
using System.Windows.Forms;
using Models.PhoneClasses;
using BLL.Implementation.Validate;
using BLL.Implementation.Folders;
using BLL.Implementation;
using Models;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер добавление телефона
    /// </summary>
    public partial class addPhoneControl : UserControl
    {
        private Phones phoneFun = new Phones();

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
            if(phoneFun.ChoosePreviewPhoto(previewFileDialog, sender as Button))
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
            if (phoneFun.ChooseMainPhotos(previewFileDialog, sender as Button))
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
            if (Validation.isPhoneExist(nameBox.Text.Trim()))
            {
                Folders.CreateFolders(choosePhotoButton, choosePreviewButton, nameBox.Text.Trim());

                Phone phone = phoneFun.CreatePhone(nameBox.Text, choosePhotoButton, priceBox.Text, screenBox.Text, cpuBox.Text,
                                         memoryBox.Text, simBox.Text, cameraBox.Text, batteryBox.Text, typeBox.Text);
                if (phoneFun.AddPhone(phone))
                {
                    MessageBox.Show("Телефон добавлен!");
                }
                else
                {
                    MessageBox.Show("Что то пошло не так!");
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Возможно данная модель телефона уже существует!");
            }
        }

        private void inputTextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void checkInputs()
        {
            if (nameBox.Text.Count() > 0  && priceBox.Text.Count() > 0 &&
                screenBox.Text.Count() > 0 && cpuBox.Text.Count() > 0 && memoryBox.Text.Count() > 0 &&
                cameraBox.Text.Count() > 0 && batteryBox.Text.Count() > 0 &&
                Validation.IsInt(priceBox.Text) && choosePreviewButton.Tag != null && choosePhotoButton.Tag != null)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void addPhoneControl_Load(object sender, EventArgs e)
        {

        }
    }
}
