using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser.Repositories;
using Models;

namespace CellularSalon.AdminPanels
{
    public partial class StocksReportsControl : UserControl
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();
        public StocksReportsControl()
        {
            InitializeComponent();
            InitializeTable();
        }

        private void InitializeTable()
        {
            List<StockOperation> stockOperations = instance.stockOperationParser.entities;

            for(int i = 0; i < stockOperations.Count; i++)
            {
                Table.Rows.Add(stockOperations[i].type, stockOperations[i].model, stockOperations[i].count, stockOperations[i].dateTime);
            }
        }
    }
}
