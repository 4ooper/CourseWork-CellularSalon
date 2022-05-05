using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeesData
    {
        public List<Sale> salePhones;

        public bool canUseAdminPanel;
        public bool canAddPhones;
        public bool canEditPhones;
        public bool canShowListOfPhones;
        public bool canChangeUsers;
        public bool canShowOrders;
        public bool canShowDataAboutSaler;
        public bool canShowSalerData;
        public bool canSold;
        public bool canShowSolds;


        public EmployeesData() { }

        public EmployeesData(bool canUseAdminPanel, bool canAddPhones, bool canEditPhones, bool canShowListOfPhones,
            bool canChangeUsers, bool canShowOrders, bool canShowDataAboutSaler, bool canShowSalerData, bool canSold, 
            bool canShowSolds)
        {
            this.salePhones = new List<Sale>();
            this.canUseAdminPanel = canUseAdminPanel;
            this.canAddPhones = canAddPhones;
            this.canEditPhones = canEditPhones;
            this.canShowListOfPhones = canShowListOfPhones;
            this.canChangeUsers = canChangeUsers;
            this.canShowOrders = canShowOrders;
            this.canShowDataAboutSaler = canShowDataAboutSaler;
            this.canShowSalerData = canShowSalerData;
            this.canSold = canSold;
            this.canShowSolds = canShowSolds;
        }

        public int totalSalePrice() => salePhones.Sum(x => x.price);


    }
}
