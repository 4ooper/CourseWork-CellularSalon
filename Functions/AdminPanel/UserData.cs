using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.PhoneClasses;

namespace BLL.AdminPanel
{
    public static class UserData
    {
        public static User CreateUser(string position, string email, string password, string name)
        {
            switch (position)
            {
                case "Пользователь":
                    return new User(email, password, name, position);
                case "Администратор":
                    return new User(email, password, name, position, true, true, true, true, true, true, true, true, true, true);
                case "Менеджер":
                    return new User(email, password, name, position, true, false, false, true, false, false, false, false, false, true);
                case "Продавец":
                    return new User(email, password, name, position, true, false, false, false, false, true, true, false, true, false);
                default:
                    return new User(email, password, name, position);
            }
        }

        public static void BindGrid(TextBox nameBox, ComboBox positionBox, TextBox emailBox, TextBox passwordBox, User user)
        {
            nameBox.Text = user.name;
            passwordBox.Text = user.password;
            emailBox.Text = user.email;
            positionBox.SelectedItem = user.position;
        }

    }
}
