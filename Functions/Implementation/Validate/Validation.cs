using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using Parser.Repositories;

namespace BLL.Implementation.Validate
{
    public static class Validation
    {
        private static ParserSingleton instance = ParserSingleton.GetInstance();

        public static bool ParseEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        public static bool IsUserExist(string email, string password)
        {
            return instance.userParser.entities.Where(item => (item.email == email) && (item.password == password)).Count() != 0;
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

        public static bool IsFilesImages(string[] pathes)
        {
            foreach (string path in pathes)
            {
                try
                {
                    Image image = Image.FromFile(path);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsFileImage(string path)
        {
            try
            {
                Image image = Image.FromFile(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isPhoneExist(string name)
        {
            return instance.phoneParser.entities.Where(item => item.name == name).ToList().Count() == 0;
        }
    }
}
