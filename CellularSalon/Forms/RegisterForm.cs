using System;
using System.Windows.Forms;
using BLL.Implementation.Registration;
using Models;
using BLL.Implementation.Validate;

namespace CellularSalon.Forms
{
    /// <summary>
    /// Окно регистрации в приложении
    /// </summary>
    public partial class RegisterForm : Form
    {
        private Registration registatration = new Registration();
        public RegisterForm(Form form)
        {
            InitializeComponent();
            regButton.Enabled = false;
            form.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new authForm(this).Show();
        }

        private void ParseFields(object sender, EventArgs e)
        {
            _ = registatration.ParseFields(nameBox.Text, passwordBox.Text, emailBox.Text) ? 
                regButton.Enabled = true : regButton.Enabled = false;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsUserExist(emailBox.Text, passwordBox.Text))
                {
                    User employee = new User(emailBox.Text, passwordBox.Text, nameBox.Text, "Пользователь");
                    if (registatration.CreateUser(employee))
                    {
                        MessageBox.Show("Вы успешно зарегистрировались!");
                        new MainForm(this, employee).Show();
                    }
                    else
                    {
                        MessageBox.Show("На данный момент регистрастрация невозможна!\n" +
                            "Если ошибка повториться обратитесь к администратору.","Ошибка");
                    }
                }
                else
                {
                    throw new Exception("Пользователь с таким e-mail уже существует!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
