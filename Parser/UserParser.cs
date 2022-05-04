using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;

namespace Parser
{
    public static class UserParser
    {
        private static string path = @"..\..\..\users.json";

        public static List<User> employees
        {
            get
            {
                return getEmployees();
            }
        }

        public static List<User> getEmployees()
        {
            List<User> employees = new List<User>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                employees = (List<User>)serializer.Deserialize(file, typeof(List<User>));
            }

            return employees;
        }

        public static bool createEmployeeNode(User item)
        {
            List<User> employee = employees;
            employee.Add(item);
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, employee);
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
        }

        public static void writeData(List<User> users)
        {
            var b = users;
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, users);
                }
                catch
                {
                }

            }
        }

        public static bool updateUser(User prevUser, User newUser)
        {
            int employeeInd = employees.FindIndex(item => item.email == prevUser.email);
            List<User> employee = employees;
            employee[employeeInd] = newUser;
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, employee);
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
    }
}
