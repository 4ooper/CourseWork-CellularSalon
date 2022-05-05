using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.PhoneClasses;
using Parser;

namespace BLL.AdminPanel
{
    public static class PhoneData
    {
        public static bool ChoosePreviewPhoto(OpenFileDialog fileDialog, Button button)
        {
            var opd = fileDialog;
            opd.Multiselect = false;
            var otv = opd.ShowDialog();
            if (otv == DialogResult.OK)
            {
                if (isFileImage(opd.FileName))
                {
                    button.Text = opd.FileName;
                    button.Tag = opd.FileName;
                    return true;
                }
                else
                {
                    MessageBox.Show("Выбранный файл не фотография!", "Ошибка");
                    return false;
                }
            }
            return false;
        }

        public static bool ChooseMainPhotos(OpenFileDialog fileDialog, Button button)
        {
            var opd = fileDialog;
            opd.Multiselect = true;
            var otv = opd.ShowDialog();
            if (otv == DialogResult.OK)
            {
                if (isFilesImages(opd.FileNames))
                {
                    button.Text = $"Выбрано: {opd.FileNames.Count()} файлов";
                    button.Tag = opd.FileNames as string[];
                    return true;
                }
                else
                {
                    MessageBox.Show("Выбранный файл не фотография!", "Ошибка");
                    return false;
                }
            }
            return false;
        }

        public static bool CreatePhone(Phone phone)
        {
            return PhoneParser.addPhone(phone);
        }

        public static bool UpdatePhone(Phone prevPhone, Phone phone)
        {
            return PhoneParser.updatePhone(prevPhone, phone);
        }

        public static bool DeletePhone(Phone phone)
        {
            return PhoneParser.deletePhone(phone);
        }

        public static string[] getStringFolders(Button choosePhotosButton, string name)
        {
            List<string> strings = new List<string>();

            string[] b = choosePhotosButton.Tag as string[];

            for (int i = 0; i < b.Length; i++)
            {
                strings.Add($"..\\..\\..\\images\\{name}\\Normal\\{i + 1}.png");
            }

            return strings.ToArray();
        }

        private static bool isFilesImages(string[] pathes)
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

        private static bool isFileImage(string path)
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
    }
}
