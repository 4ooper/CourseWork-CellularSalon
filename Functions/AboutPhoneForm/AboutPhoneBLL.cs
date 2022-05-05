using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.PhoneClasses;
using Models;
using Parser;
using BLL.CarouselPicture;

namespace BLL.AboutPhoneForm
{
    public static class AboutPhoneBLL
    {
        public static bool CreateSale(User user, Phone phone)
        {
            if (user == null)
            {
                MessageBox.Show("Необходимо зарегистрироваться для заказа.");
                return false;
            }
            else
            {
                Order order = new Order(user, phone, DateTime.Now);
                OrdersParser.createNode(order);
                MessageBox.Show("Ваш заказ отправлен. Продавец свяжется с Вами по e-mail");
                return true;
            }
        }
    }
}
