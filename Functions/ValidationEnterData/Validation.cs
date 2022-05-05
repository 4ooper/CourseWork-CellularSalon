using System;
using System.Linq;
using System.Text.RegularExpressions;
using Parser;

namespace BLL.ValidationEnterData
{
    public static class Validation
    {
        public static bool ParseEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        public static bool IsUserExist(string email)
        {
            return UserParser.employees.Where(item => item.email == email).Count() != 0;
        }

        public static bool IsInt(string item)
        {
            try
            {
                int value = Convert.ToInt32(item);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
