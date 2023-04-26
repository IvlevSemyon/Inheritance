using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DZ_Inheritance
{
    internal class Vehicle
    {
        private int year;

        public decimal Price { get; set; }
        public int Speed { get; set; }
        public int Year 
        {
            get
            {
                return year;
            }
            set 
            {
                if ( value < 1750 || value > 2023 )
                    throw new ArgumentException( "Год выпуска этой машине неправилен" );
                else 
                    year = value;
            }
        }
    }
}
