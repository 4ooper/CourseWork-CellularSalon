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
            previewFileDialog.Multiselect = false;
            var opd = previewFileDialog;
            var otv = opd.ShowDialog();
            if (otv == DialogResult.OK)
            {
                if (isFileImage(opd.FileName))
                {
                    choosePreviewButton.Text = opd.FileName;
                    choosePreviewButton.Tag = opd.FileName;
                }
                else
                {
                    MessageBox.Show("Выбранный файл не фотография!", "Ошибка");
                }
            }
            checkInputs();
        }

        private void choosePhotoButton_Click(object sender, EventArgs e)
        {
            previewFileDialog.Multiselect = true;
            var opd = previewFileDialog;
            var otv = opd.ShowDialog();
            if (otv == DialogResult.OK)
            {
                if (isFilesImages(opd.FileNames))
                {
                    choosePhotoButton.Text = $"Выбрано: {opd.FileNames.Count()} файлов";
                    choosePhotoButton.Tag = opd.FileNames as string[];
                }
                else
                {
                    MessageBox.Show("Выбранный файл не фотография!", "Ошибка");
                }
            }
            checkInputs();
        }

        private bool isFilesImages(string[] pathes)
        {
            foreach (string path in pathes)
            {
                try
                {
                    Image image = Image.FromFile(path);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private bool isFileImage(string path)
        {
            try
            {
                Image image = Image.FromFile(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            createFolders();

            Phone phone = new Phone(nameBox.Text, $"..\\..\\..\\images\\{nameBox.Text}\\small.png",
                getStringFolders(), Convert.ToInt32(countBox.Text), Convert.ToInt32(priceBox.Text), screenBox.Text, cpuBox.Text, memoryBox.Text,
                simBox.Text, cameraBox.Text, batteryBox.Text, typeBox.Text);

            if (PhoneParser.addPhone(phone))
            {
                MessageBox.Show("Телефон добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private string[] getStringFolders()
        {
            List<string> strings = new List<string>();

            string[] b = choosePhotoButton.Tag as string[];

            for (int i = 0; i < b.Length; i++)
            {
                strings.Add($"..\\..\\..\\images\\{nameBox.Text}\\Normal\\{i + 1}.png");
            }

            return strings.ToArray();
        }
        
        private void createFolders()
        {
            string[] b = choosePhotoButton.Tag as string[];
            Directory.CreateDirectory($"..\\..\\..\\images\\{nameBox.Text}");
            Directory.CreateDirectory($"..\\..\\..\\images\\{nameBox.Text}\\Normal");
            File.Copy(choosePreviewButton.Tag.ToString(), $"..\\..\\..\\images\\{nameBox.Text}\\small.png", true);
            for (int i = 0; i < b.Length; i++)
            {
                File.Copy(b[i], $"..\\..\\..\\images\\{nameBox.Text}\\Normal\\{i + 1}.png", true);
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
                cameraBox.Text.Count() > 0 && batteryBox.Text.Count() > 0 && isInt(countBox.Text) &&
                isInt(priceBox.Text) && choosePreviewButton.Tag != null && choosePhotoButton.Tag != null)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private bool isInt(string item)
        {
            try
            {
                int value = Convert.ToInt32(item);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
