using System;
using System.Windows.Forms;
using CellularSalon.UIGenerator;
using Models.PhoneClasses;
namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер для отображения списка телефонов
    /// </summary>
    public partial class ListOfPhonesControl : UserControl
    {
        private UIGeneratorPhone UIGenerator;
        public ListOfPhonesControl()
        {
            InitializeComponent();
            UIGenerator = new UIGeneratorPhone(this.panel1, aboutButton_Click, 5, 140, 230);
            UIGenerator.Generate();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AboutPhoneControl((sender as Button).Tag as Phone));
        }
    }
}
