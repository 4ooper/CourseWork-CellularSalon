using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Repositories
{
    /// <summary>
    /// Класс для описания зависимостей и реализация паттерна Одиночка
    /// </summary>
    public class ParserSingleton
    {
        private static ParserSingleton instance;

        public UserParser userParser = new UserParser(Datas_URL.UserURL);
        public OrdersParser ordersParser = new OrdersParser(Datas_URL.OrderURL);
        public PhoneParser phoneParser = new PhoneParser(Datas_URL.PhoneURL);
        public SaleParser saleParser = new SaleParser(Datas_URL.SaleURL);
        public StockParser stockParser = new StockParser(Datas_URL.StockURL);
        public StockOperationParser stockOperationParser = new StockOperationParser(Datas_URL.StockOperationURL);
        public PhoneTypeParser phoneTypeParser = new PhoneTypeParser(Datas_URL.PhoneTypeURL);

        private ParserSingleton()
        {
            
        }
        public static ParserSingleton GetInstance()
        {
            if(instance == null)
            {
                instance = new ParserSingleton();
            }
            return instance;
        }
    }
}
