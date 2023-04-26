using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class PrinterInroBetter : Printer
    {
        public override void Print( string value )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы ввели улучшенный: {0}", value);
        }
    }
}
