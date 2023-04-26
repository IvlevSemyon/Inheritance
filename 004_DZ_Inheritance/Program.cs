using _004_DZ_Inheritance.DocumentWorkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _004_DZ_Inheritance
{
    internal class Program
    {
        private const string ProLicense = "Pro000";
        private const string ExpLicense = "Exp000";

        static void Main( string[] args )
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            ConsoleColor coloredText = ConsoleColor.Cyan;

            Console.Write("Введите номер ключа доступа Pro и Exp: ");
            var license = Console.ReadLine();

            DocumentWorker worker;

            switch ( license )
            {
                case ProLicense: 
                    worker = new ProDocumentWorker();
                    Console.ForegroundColor = coloredText;
                    Console.WriteLine("Вы ввели ключ лицензии Pro");
                    Console.ForegroundColor = defaultColor;
                    break;
                case ExpLicense: 
                    worker = new ExpertDocumentWorker();
                    Console.ForegroundColor = coloredText;
                    Console.WriteLine( "Вы ввели ключ лицензии Expert" );
                    Console.ForegroundColor = defaultColor;
                    break;
                default:
                    worker = new DocumentWorker();
                    Console.ForegroundColor = coloredText;
                    Console.WriteLine("Вы ввели неправильно ключ, вы на обычной версии");
                    Console.ForegroundColor = defaultColor;
                    break;
            }

            while ( true )
            {
                Console.WriteLine("\nВведите команду (open/edit/save/quit)");
                switch ( Console.ReadLine() )
                {
                    case "open":
                        Console.ForegroundColor = coloredText;
                        worker.OpenDocument();
                        Console.ForegroundColor = defaultColor;
                        break;
                    case "edit":
                        Console.ForegroundColor = coloredText;
                        worker.EditDocument();
                        Console.ForegroundColor = defaultColor;
                        break;
                    case "save":
                        Console.ForegroundColor = coloredText;
                        worker.SaveDocument();
                        Console.ForegroundColor = defaultColor;
                        break;
                    case "quit": return;
                    default: Console.WriteLine("Вы ввели неправильную команду"); break;
                }
            }
        }
    }
}
