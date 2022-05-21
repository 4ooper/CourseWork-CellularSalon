using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using Parser;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Parser.Repositories;

namespace CellularSalonUnitTests.Sales
{
    [TestClass]
    public class SalesTest
    {
        private ParserSingleton parser = ParserSingleton.GetInstance();

        private BLL.Implementation.Sales salesFun = new BLL.Implementation.Sales();

        [TestMethod]
        public void ReadData()
        {
            string path = @"..\..\..\sales.json";

            List<Sale> saleFromTest = new List<Sale>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                saleFromTest = (List<Sale>)serializer.Deserialize(file, typeof(List<Sale>));
            }

            List<Sale> mySales = parser.saleParser.entities;

            Assert.AreEqual(saleFromTest.Count, mySales.Count);

            for (int i = 0; i < saleFromTest.Count; i++)
            {
                Assert.AreEqual(saleFromTest[i].employeeEmail, mySales[i].employeeEmail);
            }
        }

        [TestMethod]
        public void CreateSale()
        {
            bool createSale = salesFun.CreateSale(null, null);

            Assert.AreEqual(false, createSale);
        }
    }
}
