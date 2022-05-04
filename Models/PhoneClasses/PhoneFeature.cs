using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhoneFeature
    {
        public string screen { get; set; }
        public string cpu { get; set; }
        public string memory { get; set; }
        public string sim { get; set; }
        public string camera { get; set; }
        public string battery { get; set; }

        public PhoneFeature() { }

        public PhoneFeature(string screen, string cpu, string memory, string sim, string camera, string battery)
        {
            this.screen = screen;
            this.cpu = cpu;
            this.memory = memory;
            this.sim = sim;
            this.camera = camera;
            this.battery = battery;
        }
    }
}
