using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Windows.Forms;
using Parser;
using Models.PhoneClasses;
using System.Drawing;
using System.IO;

namespace BLL.Main
{
    public static class MainFormBLL
    {
        public static void BindUser(Label userNameLabel, Label userPositionLabel, Button adminPanelButton, User item = null)
        {
            if (item != null)
            {
                userNameLabel.Text = item.name;
                userPositionLabel.Text = item.position;
                adminPanelButton.Visible = false;
                if (item.employeesData != null)
                {
                    adminPanelButton.Visible = item.employeesData.canUseAdminPanel;
                }

            }
            else
            {
                userNameLabel.Text = "Гость";
                userPositionLabel.Visible = false;
                adminPanelButton.Visible = false;
            }
        }
    }
}
