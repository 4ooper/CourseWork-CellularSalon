using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Parser;
using Models;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Parser.Repositories;
using BLL.Implementation;

namespace CellularSalonUnitTests.Users
{
    [TestClass]
    public class UserTest
    {
        private ParserSingleton parser = ParserSingleton.GetInstance();
        private BLL.Implementation.Users userFun = new BLL.Implementation.Users();

        [TestMethod]
        public void ReadUsers()
        {
            string path = @"..\..\..\users.json";

            List<User> userFromTest = new List<User>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                userFromTest = (List<User>)serializer.Deserialize(file, typeof(List<User>));
            }

            List<User> myUsers = parser.userParser.entities;

            Assert.AreEqual(userFromTest.Count, myUsers.Count);

            for (int i = 0; i < userFromTest.Count; i++)
            {
                Assert.AreEqual(userFromTest[i].name, myUsers[i].name);
            }
        }

        [TestMethod]
        public void CreateUser()
        {
            User testUser = new User("testemail@mail.ru", "password", "name", "Менеджер", true, false, false, true, false, false, false, false, false, true, true);

            User createUser = userFun.CreateUser("Менеджер", "testCreate@mail.ru", "password", "name");

            Assert.AreEqual(testUser.employeesData.canShowSalerData, createUser.employeesData.canShowSalerData);
        }
    }
}
