using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
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
