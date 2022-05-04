using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Parser;

namespace CellularSalon.AdminPanels
{
    public partial class changeUserDataControl : UserControl
    {
        private User incomeUser;
        public changeUserDataControl(User item)
        {
            InitializeComponent();
            this.incomeUser = item;
            positionBox.DataSource = new string[] { "Пользователь", "Администратор", "Менеджер", "Продавец" };
            bindGrid();
        }

        private void bindGrid()
        {
            nameBox.Text = incomeUser.name;
            passwordBox.Text = incomeUser.password;
            emailBox.Text = incomeUser.email;
            positionBox.SelectedItem = incomeUser.position;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User user = createUser();
            if(UserParser.updateUser(incomeUser, user))
            {
                MessageBox.Show("Обновлено!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private User createUser()
        {
            switch (positionBox.Text)
            {
                case "Пользователь":
                    return new User(emailBox.Text, passwordBox.Text, nameBox.Text, positionBox.Text);
                case "Администратор":
                    return new User(emailBox.Text, passwordBox.Text, nameBox.Text, positionBox.Text, true, true, true, true, true, true, true, true, true, true);
                case "Менеджер":
                    return new User(emailBox.Text, passwordBox.Text, nameBox.Text, positionBox.Text, true, false, false, true, false, false, false, false, false, true);
                case "Продавец":
                    return new User(emailBox.Text, passwordBox.Text, nameBox.Text, positionBox.Text, true, false, false, false, false, true, true, false, true, false);
                default:
                    return null;
            }
        }
    }
}
