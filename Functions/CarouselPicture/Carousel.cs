using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.PhoneClasses;

namespace BLL.CarouselPicture
{
    public static class Carousel
    {
        public static void PicButtonClick(PictureBox pictureBox, Phone phone, bool next)
        {
            if (next)
            {
                NextPic(pictureBox, phone);
            }
            else
            {
                PrevPic(pictureBox, phone);
            }
        }

        private static void NextPic(PictureBox pictureBox, Phone phone)
        {
            if (Convert.ToInt32(pictureBox.Tag) + 1 < phone.normalPhotoURL.Count())
            {
                pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[Convert.ToInt32(pictureBox.Tag) + 1])));
                pictureBox.Tag = Convert.ToInt32(pictureBox.Tag) + 1;
            }
            else
            {
                pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[0])));
                pictureBox.Tag = 0;
            }
        }

        private static void PrevPic(PictureBox pictureBox, Phone phone)
        {
            if (Convert.ToInt32(pictureBox.Tag) - 1 >= 0)
            {
                pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[Convert.ToInt32(pictureBox.Tag) - 1])));
                pictureBox.Tag = Convert.ToInt32(pictureBox.Tag) - 1;
            }
            else
            {
                pictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(phone.normalPhotoURL[phone.normalPhotoURL.Count() - 1])));
                pictureBox.Tag = phone.normalPhotoURL.Count() - 1;
            }
        }
    }
}
