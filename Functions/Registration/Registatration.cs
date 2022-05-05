using System.Linq;
using System.Text.RegularExpressions;
using Models;
using Parser;
using BLL.ValidationEnterData;

namespace BLL.Registration
{
    public static class Registatration
    {
        public static bool ParseFields(string name, string password, string email)
        {
            return Validation.ParseEmail(email) && name != "" && password.Count() > 4;
        }

        public static bool CreateUser(User employee)
        {
            return UserParser.createEmployeeNode(employee);
        }
    }
}
