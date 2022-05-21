using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    /// <summary>
    /// Класс хранения URL для каждого вида файла
    /// </summary>
    public static class Datas_URL
    {
        public static string UserURL = @"..\..\..\users.json";
        public static string PhoneURL = @"..\..\..\phones.json";
        public static string SaleURL = @"..\..\..\sales.json";
        public static string OrderURL = @"..\..\..\orders.json";
        public static string StockURL = @"..\..\..\stocks.json";
        public static string StockOperationURL = @"..\..\..\stocksOperation.json";
        public static string PhoneTypeURL = @"..\..\..\phoneTypes.json";
    }
}
