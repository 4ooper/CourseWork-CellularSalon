using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StockOperation
    {
        public string type;
        public string model;
        public int count;
        public string dateTime;

        public StockOperation() { }

        public StockOperation(string type, string model, int count)
        {
            this.type = type;
            this.model = model;
            this.count = count;
            this.dateTime = $"{DateTime.Now.ToLocalTime()}";
        }
    }
}
