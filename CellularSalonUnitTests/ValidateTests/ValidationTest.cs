using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BLL.Implementation.Validate;

namespace CellularSalonUnitTests.ValidateTests
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void ParseEmailFirst()
        {
            Assert.AreEqual(false, Validation.ParseEmail("shshsh"));
        }

        [TestMethod]
        public void ParseEmailSecond()
        {
            Assert.AreEqual(true, Validation.ParseEmail("test@mail.ru"));
        }

        [TestMethod]
        public void IsUserExist()
        {
            Assert.AreEqual(true, Validation.IsUserExist("test@mail.ru"));
        }

        [TestMethod]
        public void IsInt()
        {
            Assert.AreEqual(true, Validation.IsInt("5"));
        }
    }
}
