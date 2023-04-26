using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_DZ_Inheritance
{
    internal class Program
    {
        public static void ConsolePrintPupilName()
        {
            Console.WriteLine("Pupil1 | Pupil2 | Pupil3 | Pupil4");
        }
        static void Main( string[] args )
        {
            ClassRoom cRoom = new ClassRoom( new ExcelentPupil(), new BadPupil(), new GoodPupil(), new ExcelentPupil() );

            ConsolePrintPupilName();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();
            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();

            Console.ReadKey();
        }
    }
}
