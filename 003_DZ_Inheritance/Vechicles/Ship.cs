using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DZ_Inheritance
{
    internal class Ship : Vehicle
    {
        public int PassengerCount { get; set; }
        public string HomePort { get; set; }
    }
}
