using System.Linq;
using Models;
using Parser.Repositories;
using BLL.Implementation.Validate;
using System.Collections.Generic;
using BLL.Interfaces;

namespace BLL.Implementation.Registration
{
    public class Registration : IRegistaration
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        public bool ParseFields(string name, string password, string email)
        {
            return Validation.ParseEmail(email) && name != "" && password.Count() > 4;
        }

        public bool CreateUser(User item)
        {
            List<User> employee = instance.userParser.entities;
            employee.Add(item);
            return instance.userParser.writeData(employee);
        }
    }
}
