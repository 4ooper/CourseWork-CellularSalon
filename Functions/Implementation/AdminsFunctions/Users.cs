using Models;
using Parser.Repositories;
using System;
using System.Collections.Generic;
using BLL.Interfaces;

namespace BLL.Implementation
{
    public class Users : IUser
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        public User CreateUser(string position, string email, string password, string name)
        {
            switch (position)
            {
                case "Пользователь":
                    return new User(email, password, name, position);
                case "Администратор":
                    return new User(email, password, name, position, true, true, true, true, true, true, true, true, true, true, true);
                case "Менеджер":
                    return new User(email, password, name, position, true, false, false, true, false, false, false, false, false, true, true);
                case "Продавец":
                    return new User(email, password, name, position, true, false, false, false, false, true, true, false, true, false, false);
                default:
                    return new User(email, password, name, position);
            }
        }

        public bool UpdateUser(User incomeUser, User newUser)
        {
            int employeeInd = instance.userParser.entities.FindIndex(item => item.email == incomeUser.email);
            List<User> employee = instance.userParser.entities;
            employee[employeeInd] = newUser;
            return instance.userParser.writeData(employee); 
        }
    }
}
