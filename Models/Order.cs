using System;


namespace Models
{
    /// <summary>
    /// Класс описания заказа
    /// </summary>
    public class Order
    {
        public User user;
        public PhoneClasses.Phone phone;
        public DateTime date;

        public Order() { }

        public Order(User user, PhoneClasses.Phone phone, DateTime date)
        {
            this.user = user;
            this.phone = phone;
            this.date = date;
        }
    }
}
