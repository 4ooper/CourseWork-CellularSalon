namespace Models.PhoneClasses
{
    /// <summary>
    /// Класс описание телефона
    /// </summary>
    public class Phone
    {
        public string name;
        public string smallPhotoURL;
        public string[] normalPhotoURL;
        public Type type;
        public int standartPrice;
        public PhoneFeature features;

        public Phone() { }

        public Phone(string name, string smallPhotoURL, string[] normalPhotoURL, 
                     int price, string screen, string cpu, 
                     string memory, string sim, string camera, string battery, Type type)
        {
            this.name = name;
            this.smallPhotoURL = smallPhotoURL;
            this.normalPhotoURL = normalPhotoURL;
            this.standartPrice = price;
            this.features = new PhoneFeature(screen, cpu, memory, sim, camera, battery);
            this.type = type;
        }

        public int totalPrice() => standartPrice + (standartPrice * type.margin) / 100;
    } 
}
