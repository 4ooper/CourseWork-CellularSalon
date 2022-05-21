using System.Collections.Generic;
using System.IO;
using Models;
using Newtonsoft.Json;

namespace Parser
{
    /// <summary>
    /// Класс для сериалиализации и десириализации заказов
    /// </summary>
    public class OrdersParser : Parser<Order>
    {
        public OrdersParser(string filepath) : base(filepath)
        {
        }
    }
}
