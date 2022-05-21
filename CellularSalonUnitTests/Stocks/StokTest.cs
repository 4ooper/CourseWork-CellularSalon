using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Parser;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Parser.Repositories;

namespace CellularSalonUnitTests.Stocks
{
    [TestClass]
    public class StokTest
    {
        private ParserSingleton parser = ParserSingleton.GetInstance();

        [TestMethod]
        public void ReadData()
        {
            string path = @"..\..\..\stocks.json";

            List<Stock> testData = new List<Stock>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                testData = (List<Stock>)serializer.Deserialize(file, typeof(List<Stock>));
            }

            List<Stock> myData = parser.stockParser.entities;

            Assert.AreEqual(testData.Count, myData.Count);

            for (int i = 0; i < testData.Count; i++)
            {
                Assert.AreEqual(testData[i].model, myData[i].model);
            }
        }
    }
}
