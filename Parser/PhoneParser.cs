using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.PhoneClasses;
using Newtonsoft.Json;

namespace Parser
{
    public static class PhoneParser
    {
        public static List<Phone> phones
        {
            get
            {
                return getPhones();
            }
        }

        public static string[] models
        {
            get
            {
                return getPhones().Select(item => item.name).Distinct().ToArray();
            }
        }

        private static string path = @"..\..\..\phones.json";

        public static bool addPhone(Phone item)
        {

            if(isPhoneExist(item.name) == false)
            {
                return false;
            }

            List<Phone> phones = PhoneParser.phones;

            phones.Add(item);

            return writeData(phones);
        }

        public static bool deletePhone(Phone phone)
        {
            List<Phone> phones = PhoneParser.phones;
            int id = phones.FindIndex(item => item.name == phone.name);
            phones.RemoveAt(id);

            return writeData(phones);
        }

        public static bool updatePhone(Phone prevPhone, Phone newPhone)
        {
            List<Phone> phones = PhoneParser.phones;
            int id = phones.FindIndex(item => item.name == prevPhone.name);
            phones[id] = newPhone;
            return writeData(phones);
        }

        private static bool isPhoneExist(string name)
        {
            return PhoneParser.phones.Where(item => item.name == name).ToList().Count() == 0;
        }

        private static List<Phone> getPhones()
        {
            List<Models.PhoneClasses.Phone> phones = new List<Models.PhoneClasses.Phone>();

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                phones = (List<Phone>)serializer.Deserialize(file, typeof(List<Models.PhoneClasses.Phone>));
            }

            return phones;
        }

        public static bool writeData(List<Phone> phones)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, phones);
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
