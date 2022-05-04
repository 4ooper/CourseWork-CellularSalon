using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;

namespace Parser
{
    public static class SaleParser
    {
        public static List<Sale> sales
        {
            get
            {
                return getSales();
            }
        }

        private static string path = @"..\..\..\sales.json";


        private static List<Sale> getSales()
        {
            List<Sale> sales = new List<Sale>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                sales = (List<Sale>)serializer.Deserialize(file, typeof(List<Sale>));
            }

            return sales;
        }

        public static bool writeData(List<Sale> sales)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, sales);
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
