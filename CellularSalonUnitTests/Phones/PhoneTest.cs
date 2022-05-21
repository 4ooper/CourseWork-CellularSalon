using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.PhoneClasses;
using Parser;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Parser.Repositories;
using BLL.Implementation.Validate;

namespace CellularSalonUnitTests.Phones
{
    [TestClass]
    public class PhoneTest
    {
        private ParserSingleton parser = ParserSingleton.GetInstance();
        [TestMethod]
        public void ReadData()
        {
            string path = @"..\..\..\phones.json";

            List<Phone> testData = new List<Phone>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                testData = (List<Phone>)serializer.Deserialize(file, typeof(List<Phone>));
            }

            List<Phone> myData = parser.phoneParser.entities;

            Assert.AreEqual(testData.Count, myData.Count);

            for (int i = 0; i < testData.Count; i++)
            {
                Assert.AreEqual(testData[i].name, myData[i].name);
            }
        }

        [TestMethod]
        public void IsPhoneExist1()
        {
            Assert.AreEqual(false, Validation.isPhoneExist("APPLE iPhone SE"));
        }

        [TestMethod]
        public void IsPhoneExist2()
        {
            Assert.AreEqual(true, Validation.isPhoneExist("APPLE iPhone 3"));
        }
    }
}
