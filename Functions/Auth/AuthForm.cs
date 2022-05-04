using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Models;
using Parser;

namespace Functions.Auth
{
    public static class AuthForm
    {
        public static bool EmailValidation(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        public static bool isDataExist(string email, string password)
        {
            List<User> employess = UserParser.employees;
            List<User> findItem = employess.Where(item => item.email == email && item.password == password).ToList();
            return findItem == null ? false : true;
        }

        public static User getItem(string email, string password)
        {
            return UserParser.employees.Where(item => item.email == email && item.password == password).ToArray()[0];
        }

        //public Employee registerUser(string email, string password, string name)
        //{

        //}

    }
}
