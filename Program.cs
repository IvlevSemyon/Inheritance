using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main( string[] args )
        {
            ConsoleColor defaultColor = Console.ForegroundColor;

            PrinterInroBetter printerInroBetter = new PrinterInroBetter();
            printerInroBetter.Print( "Hey hey" );
            Console.ForegroundColor = defaultColor;

            Printer printer = printerInroBetter as Printer;
            printer.Print( "Vou vou" );
            Console.ForegroundColor= defaultColor;

            PrinterInfo printerInfo = new PrinterInfo();
            printerInfo.Print( "Iou iou" );
            Console.ForegroundColor = defaultColor;

            Printer printer1 = new Printer();
            printer1.Print( "Yeah yeah" );
            Console.ForegroundColor = defaultColor;
        }
    }
}
