using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Parser;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Parser.Repositories;

namespace CellularSalonUnitTests
{
    [TestClass]
    public class OrdersParserUnitTest
    {
        private ParserSingleton parser = ParserSingleton.GetInstance(); 
        [TestMethod]
        public void ReadData()
        {
            string path = @"..\..\..\orders.json";

            List<Order> testData = new List<Order>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                testData = (List<Order>)serializer.Deserialize(file, typeof(List<Order>));
            }

            List<Order> myData = parser.ordersParser.entities;

            Assert.AreEqual(testData.Count, myData.Count);

            for (int i = 0; i < testData.Count; i++)
            {
                Assert.AreEqual(testData[i].phone.name, myData[i].phone.name);
            }
        }
    }
}
