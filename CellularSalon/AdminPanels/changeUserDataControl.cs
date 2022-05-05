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
using BLL.AdminPanel;

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
            UserData.BindGrid(nameBox, positionBox, emailBox, passwordBox, item);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User user = UserData.CreateUser(positionBox.Text, emailBox.Text, passwordBox.Text, nameBox.Text);
            if(UserParser.updateUser(incomeUser, user))
            {
                MessageBox.Show("Обновлено!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
