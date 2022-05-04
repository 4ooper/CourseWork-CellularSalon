using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Phone
{
    public struct PhoneType
    {
        public EnumTypes type { get; set; }
        public int margin { get; set; }

        public PhoneType(string type, int margin)
        {
            this.type = EnumTypes.smartPhone;
            this.margin = margin;
            this.type = StringToEnum(type);
        }

        private EnumTypes StringToEnum(string type)
        {
            switch (type)
            {
                case "Фичерфон":
                    return EnumTypes.ficherPhone;
                default:
                    return EnumTypes.smartPhone;
            }
        }
    }
}
