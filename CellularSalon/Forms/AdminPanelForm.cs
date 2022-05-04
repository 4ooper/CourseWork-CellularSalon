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
using CellularSalon.AdminPanels;

namespace CellularSalon.Forms
{
    public partial class adminPanelForm : Form
    {
        private User user;
        public adminPanelForm(Form form, User item)
        {
            InitializeComponent();
            userName.Text = item.name;
            userPosition.Text = item.position;
            this.user = item;
            setPermissions();
            form.Hide();
        }

        private void setPermissions()
        {
            addPhoneButton.Enabled = user.employeesData.canAddPhones;
            editPhoneButton.Enabled = user.employeesData.canEditPhones;
            listOfPHonesButton.Enabled = user.employeesData.canShowListOfPhones;
            canChangeUserData.Enabled = user.employeesData.canChangeUsers;
            orderButton.Enabled = user.employeesData.canShowOrders;
            aboutSalerButton.Enabled = user.employeesData.canShowDataAboutSaler;
            salerButton.Enabled = user.employeesData.canShowSalerData;
            saleButton.Enabled = user.employeesData.canSold;
            showSalesButton.Enabled = user.employeesData.canShowSolds;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new FindUserControl());
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new addPhoneControl());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MainForm(this, user).Show();
        }

        private void deletePhoneButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new FindPhoneControl());
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new OrderControl(user));
        }

        private void salerButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new FindSalerControl());
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new SaleControl(user));
        }

        private void showSalesButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new ReportsControl());
        }

        private void listOfPhonesButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new ListOfPhonesControl());
        }

        private void aboutSalerButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new AboutSalerControl(user.name));
        }
    }
}
