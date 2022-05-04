using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions.Registration;
using Models;

namespace CellularSalon.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm(Form form)
        {
            InitializeComponent();
            regButton.Enabled = false;
            form.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new authForm(this).Show();
        }

        private void parseFields(object sender, EventArgs e)
        {
            if(Registatration.parseFields(nameBox.Text, passwordBox.Text, emailBox.Text))
            {
                regButton.Enabled = true;
            }
            else
            {
                regButton.Enabled = false;
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            User employee = new User(emailBox.Text, passwordBox.Text, nameBox.Text, "Пользователь");
            try
            {
                if (Registatration.isUserExist(employee))
                {
                    if (Registatration.createUser(employee))
                    {
                        MessageBox.Show("Success");
                        new MainForm(this, employee).Show();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
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
