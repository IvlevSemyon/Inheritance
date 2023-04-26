using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_DZ_Inheritance
{
    internal class Pupil
    {
        public virtual void Study( )
        {
            Console.WriteLine("Учится");
        }

        public virtual void Read()
        {
            Console.WriteLine( "Читает" );
        }

        public virtual void Write()
        {
            Console.WriteLine( "Пишет" );
        }

        public virtual void Relax()
        {
            Console.WriteLine( "Отдыхает" );
        }
    }
}
