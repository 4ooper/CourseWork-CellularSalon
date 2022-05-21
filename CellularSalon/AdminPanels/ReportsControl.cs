using System;
using System.Windows.Forms;
using CellularSalon.UIGenerator;

namespace CellularSalon.AdminPanels
{
    /// <summary>
    /// Контроллер отображения отчётов по продажам
    /// </summary>
    public partial class ReportsControl : UserControl
    {
        private UIGeneratorSales generatorSales;
        public ReportsControl()
        {
            InitializeComponent();
            generatorSales = new UIGeneratorSales(this, reportButton_Click, 20, 130, 70);
            generatorSales.Generate();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string link = (sender as Button).Tag as string;
            System.Diagnostics.Process.Start(link);
        }
    }
}
