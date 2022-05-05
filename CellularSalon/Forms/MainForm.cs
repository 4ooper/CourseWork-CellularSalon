using System;
using System.Windows.Forms;
using Models;
using Models.PhoneClasses;
using BLL.Main;
using BLL.UIGenerator;

namespace CellularSalon.Forms
{
    public partial class MainForm : Form
    {
        private User user;
        public MainForm(Form form, User item = null)
        {
            InitializeComponent();
            MainFormBLL.BindUser(this.userName, this.userPosition, this.adminPanelButton, item);
            user = item;
            form.Hide();
            UIGenerator.AddPhones(this.mainPanel, AboutButton_Click, 50);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutPhoneForm(this, (Phone)(sender as Button).Tag, user == null ? null : user).Show();
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            new adminPanelForm(this, user).Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.user = null;
            new authForm().Show();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
