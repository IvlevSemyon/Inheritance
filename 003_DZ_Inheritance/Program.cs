using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DZ_Inheritance
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Car car = new Car();
            car.Price = 43000;
            car.Speed = 350;
            car.Year = 2022;

            Ship ship = new Ship();
            ship.Price = 430000;
            ship.Speed = 90;
            ship.Year = 2014;
            ship.PassengerCount = 140;
            ship.HomePort = "Galereya";

            Plane plane = new Plane();
            plane.Price = 860000;
            plane.Speed = 560;
            plane.Year = 2016;
            plane.PassengerCount = 280;
            plane.Height = 4;

            Console.WriteLine("Car:");
            Console.WriteLine("Price: " +  car.Price);
            Console.WriteLine( "Speed: " + car.Speed );
            Console.WriteLine( "Year: " + car.Year );

            Console.WriteLine("\n");

            Console.WriteLine( "Ship:" );
            Console.WriteLine("Price: " + ship.Price);
            Console.WriteLine( "Speed: " + ship.Speed );
            Console.WriteLine( "Year: " + ship.Year );
            Console.WriteLine( "PassengerCount: " + ship.PassengerCount );
            Console.WriteLine( "HomePort: " + ship.HomePort );

            Console.WriteLine( "\n" );

            Console.WriteLine( "Plane:" );
            Console.WriteLine("Price: " + plane.Price);
            Console.WriteLine( "Speed: " + plane.Speed );
            Console.WriteLine( "Year: " + plane.Year );
            Console.WriteLine( "PassengerCount: " + plane.PassengerCount );
            Console.WriteLine( "Height: " + plane.Height );
        }
    }
}
