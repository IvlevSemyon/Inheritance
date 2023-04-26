using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class PrinterInfo : Printer
    {
        public override void Print( string value )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы вывели: {0}", value);
        }
    }
}
