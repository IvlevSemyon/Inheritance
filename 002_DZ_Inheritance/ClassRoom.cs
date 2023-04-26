using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_DZ_Inheritance
{
    internal class ClassRoom
    {
        Pupil[] pupils;

        public ClassRoom( Pupil p1, Pupil p2, Pupil p3, Pupil p4 )
        {
            pupils = new Pupil[] { p1, p2, p3, p4 };
        }

        public ClassRoom( Pupil p1, Pupil p2, Pupil p3 )
        {
            pupils = new Pupil[] { p1, p2, p3 };
        }

        public ClassRoom( Pupil p1, Pupil p2 )
        {
            pupils = new Pupil[] { p1, p2 };
        }

        public void PrintInfoStudy()
        {
            Console.WriteLine("\nStudy: ");
            foreach (var pupil in pupils)
            {
                pupil.Study();
            }
        }

        public void PrintInfoWrite( )
        {
            Console.WriteLine( "\nWrite: " );
            foreach ( var pupil in pupils )
            {
                pupil.Write();
            }
        }

        public void PrintInfoRead( )
        {
            Console.WriteLine( "\nRead: " );
            foreach ( var pupil in pupils )
            {
                pupil.Read();
            }
        }

        public void PrintInfoRelax( )
        {
            Console.WriteLine( "\nRelax: " );
            foreach ( var pupil in pupils )
            {
                pupil.Relax();
            }
        }
    }
}
