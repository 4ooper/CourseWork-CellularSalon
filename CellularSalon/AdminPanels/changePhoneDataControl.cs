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
                isInt(priceBox.Text) && previewButton.Tag != null && mainPhotoButton.Tag != null)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pictureBox1.Tag) + 1 < incomePhone.normalPhotoURL.Count())
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(incomePhone.normalPhotoURL[Convert.ToInt32(pictureBox1.Tag) + 1])));
                pictureBox1.Tag = Convert.ToInt32(pictureBox1.Tag) + 1;
            }
            else
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(incomePhone.normalPhotoURL[0])));
                pictureBox1.Tag = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pictureBox1.Tag) - 1 >= 0)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(incomePhone.normalPhotoURL[Convert.ToInt32(pictureBox1.Tag) - 1])));
                pictureBox1.Tag = Convert.ToInt32(pictureBox1.Tag) - 1;
            }
            else
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(incomePhone.normalPhotoURL[incomePhone.normalPhotoURL.Count() - 1])));
                pictureBox1.Tag = incomePhone.normalPhotoURL.Count() - 1;
            }
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            photoFileDialog.Multiselect = false;
            var opd = photoFileDialog;
            var otv = opd.ShowDialog();
            if (otv == DialogResult.OK)
            {
                if (isFileImage(opd.FileName))
                {
                    previewButton.Text = opd.FileName;
                    previewButton.Tag = opd.FileName;
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
                    Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(path)));
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
                Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(path)));
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void mainPhotoButton_Click(object sender, EventArgs e)
        {
            photoFileDialog.Multiselect = true;
            var opd = photoFileDialog;
            var otv = opd.ShowDialog();
            if (otv == DialogResult.OK)
            {
                if (isFilesImages(opd.FileNames))
                {
                    mainPhotoButton.Text = $"Выбрано: {opd.FileNames.Count()} файлов";
                    mainPhotoButton.Tag = opd.FileNames as string[];
                }
                else
                {
                    MessageBox.Show("Выбранный файл не фотография!", "Ошибка");
                }
            }
            checkInputs();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            createFolders();
            deleteFolders();
            moveFromTmp();
            //if(nameBox.Text != incomePhone.name)
            //{
            //    createFolders();
            //    deleteFolders();
            //}

            Phone phone = new Phone(nameBox.Text, $"..\\..\\..\\images\\{nameBox.Text}\\small.png",
                getStringFolders(), incomePhone.count, Convert.ToInt32(priceBox.Text), screenBox.Text, cpuBox.Text, memoryBox.Text,
                simBox.Text, cameraBox.Text, accumBox.Text, typeBox.Text);

            if(PhoneParser.updatePhone(incomePhone, phone))
            {
                MessageBox.Show("Выполнено!");
            }
            else
            {
                MessageBox.Show("Что то пошло не так!");
            }
        }

        private void moveFromTmp()
        {
            Directory.Move($"..\\..\\..\\images\\tmp\\{nameBox.Text}", $"..\\..\\..\\images\\{nameBox.Text}");
        }

        private void clearTmp()
        {
            Directory.Delete($"..\\..\\..\\images\\tmp\\{nameBox.Text}", true);
        }

        private void deleteFolders()
        {
            Directory.Delete($"..\\..\\..\\images\\{incomePhone.name}", true);
        }

        private string[] getStringFolders()
        {
            List<string> strings = new List<string>();

            string[] b = mainPhotoButton.Tag as string[];

            for (int i = 0; i < b.Length; i++)
            {
                strings.Add($"..\\..\\..\\images\\{nameBox.Text}\\Normal\\{i + 1}.png");
            }

            return strings.ToArray();
        }

        private void createFolders()
        {
            string[] b = mainPhotoButton.Tag as string[];
            Directory.CreateDirectory($"..\\..\\..\\images\\tmp\\{nameBox.Text}");
            Directory.CreateDirectory($"..\\..\\..\\images\\tmp\\{nameBox.Text}\\Normal");
            File.Copy(previewButton.Tag.ToString(), $"..\\..\\..\\images\\tmp\\{nameBox.Text}\\small.png", true);
            for (int i = 0; i < b.Length; i++)
            {
                File.Copy(b[i], $"..\\..\\..\\images\\tmp\\{nameBox.Text}\\Normal\\{i + 1}.png", true);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteFolders();
            if (PhoneParser.deletePhone(incomePhone))
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
