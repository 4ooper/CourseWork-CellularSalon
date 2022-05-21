using System.Collections.Generic;
using System.IO;
using System.Linq;
using Models.PhoneClasses;
using Newtonsoft.Json;

namespace Parser
{
    /// <summary>
    /// Класс для чтения и записи телефонов
    /// </summary>
    public class PhoneParser : Parser<Phone>
    {
        public string[] models
        {
            get
            {
                return entities.Select(item => item.name).Distinct().ToArray();
            }
        }

        public PhoneParser(string filepath) : base(filepath)
        {
        }

        public bool addPhone(Phone item)
        {
            List<Phone> phones = entities;

            phones.Add(item);

            return writeData(phones);
        }

        public bool deletePhone(Phone phone)
        {
            List<Phone> phones = entities;
            int id = phones.FindIndex(item => item.name == phone.name);
            phones.RemoveAt(id);

            return writeData(phones);
        }

        public bool updatePhone(Phone prevPhone, Phone newPhone)
        {
            List<Phone> phones = entities;
            int id = phones.FindIndex(item => item.name == prevPhone.name);
            phones[id] = newPhone;
            return writeData(phones);
        }
    }
}
