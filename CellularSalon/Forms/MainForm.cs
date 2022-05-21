using System;
using System.Windows.Forms;
using Models;
using Models.PhoneClasses;
using CellularSalon.UIGenerator;

namespace CellularSalon.Forms
{
    /// <summary>
    /// Главное окно приложения
    /// </summary>
    public partial class MainForm : Form
    {
        private User user;
        private UIGeneratorPhone UIGenerator;
        public MainForm(Form form, User item = null)
        {
            InitializeComponent();
            user = item;
            BindUser();
            form.Hide();
            UIGenerator = new UIGeneratorPhone(this.mainPanel, AboutButton_Click, 50, 140, 230);
            UIGenerator.Generate();
        }

        public void BindUser()
        {
            if (user != null)
            {
                userName.Text = user.name;
                userPosition.Text = user.position;
                adminPanelButton.Visible = false;
                if (user.employeesData != null)
                {
                    adminPanelButton.Visible = user.employeesData.canUseAdminPanel;
                }

            }
            else
            {
                userName.Text = "Гость";
                userPosition.Visible = false;
                adminPanelButton.Visible = false;
            }
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
