using System;
using System.Windows.Forms;
using Models;
using BLL.Implementation;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер для изменения пользователя
    /// </summary>
    public partial class changeUserDataControl : UserControl
    {
        private User incomeUser;
        private Users users = new Users();
        public changeUserDataControl(User item)
        {
            InitializeComponent();
            this.incomeUser = item;
            positionBox.DataSource = new string[] { "Пользователь", "Администратор", "Менеджер", "Продавец" };
            BindGrid();
        }

        private void BindGrid()
        {
            nameBox.Text = incomeUser.name;
            passwordBox.Text = incomeUser.password;
            emailBox.Text = incomeUser.email;
            positionBox.SelectedItem = incomeUser.position;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User user = users.CreateUser(positionBox.Text, emailBox.Text, passwordBox.Text, nameBox.Text);
            if(users.UpdateUser(incomeUser, user))
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
