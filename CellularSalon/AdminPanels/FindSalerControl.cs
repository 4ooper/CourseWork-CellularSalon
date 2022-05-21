using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Parser.Repositories;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер для поиска продавца и просмотра информации о продавце
    /// </summary>
    public partial class FindSalerControl : UserControl
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        public FindSalerControl()
        {
            InitializeComponent();
            comboBox1.DataSource = instance.userParser.entities.Where(item => item.position == "Продавец").Select(item => item.name).ToList();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AboutSalerControl(comboBox1.SelectedItem.ToString()));
        }
    }
}
