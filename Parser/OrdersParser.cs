using System.Collections.Generic;
using System.IO;
using Models;
using Newtonsoft.Json;

namespace Parser
{
    public static class OrdersParser
    {
        public static List<Order> orders
        {
            get
            {
                return GetOrders();
            }
        }

        public static int countOfOrders
        {
            get
            {
                return orders.Count;
            }
        }

        private static string path = @"..\\..\\..\\orders.json";

        private static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                orders = (List<Order>)serializer.Deserialize(file, typeof(List<Order>));
            }

            return orders == null ? new List<Order>() : orders;
        }

        public static bool createNode(Order item)
        {
            List<Order> orders = OrdersParser.orders;
            orders.Add(item);
            return writeNotes(orders);
        }

        public static bool deleteNode(Order item)
        {
            List<Order> orders = OrdersParser.orders;
            orders.Remove(item);

            return writeNotes(orders);
        }

        public static bool writeNotes(List<Order> orders)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, orders);
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
    }
}
