using System.IO;
using System.Windows.Forms;

namespace BLL.Implementation.Folders
{
    public static class Folders
    {
        public static void CreateFolders(Button mainPhotosButton, Button previewPhotoButton, string name)
        {
            string[] b = mainPhotosButton.Tag as string[];
            Directory.CreateDirectory($"..\\..\\..\\images\\{name}");
            Directory.CreateDirectory($"..\\..\\..\\images\\{name}\\Normal");
            File.Copy(previewPhotoButton.Tag.ToString(), $"..\\..\\..\\images\\{name}\\small.png", true);
            for (int i = 0; i < b.Length; i++)
            {
                File.Copy(b[i], $"..\\..\\..\\images\\{name}\\Normal\\{i + 1}.png", true);
            }
        }

        public static void CreateTempFolders(Button mainPhotosButton, Button previewPhotoButton, string name)
        {
            string[] b = mainPhotosButton.Tag as string[];
            Directory.CreateDirectory($"..\\..\\..\\images\\tmp\\{name}");
            Directory.CreateDirectory($"..\\..\\..\\images\\tmp\\{name}\\Normal");
            File.Copy(previewPhotoButton.Tag.ToString(), $"..\\..\\..\\images\\tmp\\{name}\\small.png", true);
            for (int i = 0; i < b.Length; i++)
            {
                File.Copy(b[i], $"..\\..\\..\\images\\tmp\\{name}\\Normal\\{i + 1}.png", true);
            }
        }

        public static void moveFromTmp(string name)
        {
            Directory.Move($"..\\..\\..\\images\\tmp\\{name}", $"..\\..\\..\\images\\{name}");
        }

        public static void deleteFolders(string name)
        {
            Directory.Delete($"..\\..\\..\\images\\{name}", true);
        }
    }
}
