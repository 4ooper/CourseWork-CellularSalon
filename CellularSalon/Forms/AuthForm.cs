using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser;
using Functions;
using Models;

namespace CellularSalon.Forms
{
    public partial class authForm : Form
    {
        public authForm(Form form = null)
        {
            InitializeComponent();
            label4.Visible = false;
            regButton.Enabled = false;
            if(form != null)
            {
                form.Hide();
            }
        }

        private void authDataChanged(object sender, EventArgs e)
        {
            if (Functions.Auth.AuthForm.EmailValidation(emailBox.Text) == true && passwordBox.Text.Count() > 4)
            {
                label4.Visible = false;
                regButton.Enabled = true;
            }
            else
            {
                label4.Visible = true;
                regButton.Enabled = false;
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordBox.Text.Count() == 0)
                {
                    throw new Exception("No password");
                }

                if (Functions.Auth.AuthForm.isDataExist(emailBox.Text, passwordBox.Text))
                {
                    User item = Functions.Auth.AuthForm.getItem(emailBox.Text, passwordBox.Text);
                    new MainForm(this, item).Show();
                }
                else
                {
                    throw new Exception("Not find data");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Неправильные данные!", "Ошибка!");
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            new MainForm(this).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RegisterForm(this).Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
