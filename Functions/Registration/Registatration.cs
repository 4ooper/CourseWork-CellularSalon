using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Models;
using Parser;

namespace Functions.Registration
{
    public static class Registatration
    {
        public static bool parseEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        public static bool parseFields(string name, string password, string email)
        {
            if (parseEmail(email) && name != "" && password.Count() > 4)
            {
                return true;
            }
            return false;
        }

        public static bool createUser(User employee)
        {
            if (UserParser.createEmployeeNode(employee))
            {
                return true;
            }
            return false;
        }

        public static bool isUserExist(User employee)
        {
            return UserParser.employees.Where(item => item.email == employee.email).Count() == 0;
        }
    }
}
