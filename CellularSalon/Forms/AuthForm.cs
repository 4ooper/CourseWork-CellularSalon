using System;
using System.Linq;
using System.Windows.Forms;
using Models;
using BLL.Implementation.Validate;
using BLL.Implementation.Authentication;

namespace CellularSalon.Forms
{
    /// <summary>
    /// Окно для аутенфикации в приложении
    /// </summary>
    public partial class authForm : Form
    {
        private Authentication authentication = new Authentication();
        public authForm(Form form = null)
        {
            InitializeComponent();
            label4.Visible = false;
            SingInButton.Enabled = false;
            if(form != null)
            {
                form.Hide();
            }
        }

        private void AuthDataChanged(object sender, EventArgs e)
        {
            if (Validation.ParseEmail(emailBox.Text) == true && passwordBox.Text.Count() > 4)
            {
                label4.Visible = false;
                SingInButton.Enabled = true;
            }
            else
            {
                label4.Visible = true;
                SingInButton.Enabled = false;
            }
        }

        private void SingInButton_Click(object sender, EventArgs e)
        {
            if(Validation.IsUserExist(emailBox.Text, passwordBox.Text))
            {
                User item = authentication.GetItem(emailBox.Text, passwordBox.Text);
                new MainForm(this, item).Show();
            }
            else
            {
                MessageBox.Show("Пользователь не найден!\nПроверьте данные для входа", "Ошибка!");
            }
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            new MainForm(this).Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            new RegisterForm(this).Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void authForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
