using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public EmployeesData employeesData { get; set; }

        public User() { }
        public User(string email, string password, string name, string position)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.position = position;
            this.employeesData = null;
        }

        public User(string email, string password, string name, string position, EmployeesData employeesData)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.position = position;
            this.employeesData = employeesData;
        }

        public User(string email, string password, string name, string position, bool canUseAdminPanel, bool canAddPhones, 
            bool canEditPhones, bool canShowListOfPhones, bool canChangeUsers, bool canShowOrders, 
            bool canShowDataAboutSaler, bool canShowSalerData, bool canSold, bool canShowSolds)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.position = position;
            this.employeesData = new EmployeesData(canUseAdminPanel, canAddPhones, canEditPhones, canShowListOfPhones,
                canChangeUsers, canShowOrders, canShowDataAboutSaler, canShowSalerData, canSold, canShowSolds);
        }
    }
}
