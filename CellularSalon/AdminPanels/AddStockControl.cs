using System.Windows.Forms;
using Parser.Repositories;
using BLL.Implementation.Validate;
using BLL.Implementation;
using Models;
using System;
using System.Linq;

namespace CellularSalon.AdminPanels
{
    public partial class AddStockControl : UserControl
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();
        private Phones phonesFun = new Phones();
        public AddStockControl()
        {
            InitializeComponent();
            modelsBox.DataSource = instance.stockParser.entities.Select(item => item.model).ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation.IsInt(countBox.Text))
            {
                Stock stock = instance.stockParser.entities.Find(item => item.model == modelsBox.Text);
                if(phonesFun.AddCountToPhone(stock, Convert.ToInt32(countBox.Text)))
                {
                    MessageBox.Show("Операция проведена!");
                }
            }
            else
            {
                MessageBox.Show("Количество невалидно", "Ошибка!");
            }
        }
    }
}
