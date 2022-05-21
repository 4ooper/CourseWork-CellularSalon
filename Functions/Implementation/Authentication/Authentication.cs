using System.Linq;
using Models;
using Parser.Repositories;
using BLL.Interfaces;


namespace BLL.Implementation.Authentication
{
    public class Authentication : IAuthenficaton
    {
        private ParserSingleton instance = ParserSingleton.GetInstance();

        public Authentication() { }
        public User GetItem(string email, string password)
        {
            return instance.userParser.entities.Where(item => item.email == email && item.password == password).ToArray()[0];
        }
    }
}
