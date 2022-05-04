using Models.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PhoneClasses
{
    public class Phone
    {
        public string name;
        public string smallPhotoURL;
        public string[] normalPhotoURL;
        public int count;
        public PhoneType type;
        public int standartPrice;
        public PhoneFeature features;

        public Phone() { }

        public Phone(string name, string smallPhotoURL, string[] normalPhotoURL, 
                     int count, int price, string screen, string cpu, 
                     string memory, string sim, string camera, string battery, string type)
        {
            this.name = name;
            this.smallPhotoURL = smallPhotoURL;
            this.normalPhotoURL = normalPhotoURL;
            this.count = count;
            this.standartPrice = price;
            this.features = new PhoneFeature(screen, cpu, memory, sim, camera, battery);
            this.type = new PhoneType(type, type == "Смартфон" ? 10 : 15);
        }

        public int totalPrice() => standartPrice + (standartPrice * type.margin) / 100;
    } 
}
