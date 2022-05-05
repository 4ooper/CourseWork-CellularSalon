using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Models;
using Parser;

namespace BLL.Auth
{
    public static class AuthForm
    {
        public static User getItem(string email, string password)
        {
            return UserParser.employees.Where(item => item.email == email && item.password == password).ToArray()[0];
        }
    }
}
