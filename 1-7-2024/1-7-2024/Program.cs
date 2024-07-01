using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Car's make");
            string Make = Console.ReadLine();
            Console.WriteLine("Enter Car's year");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Car's type");
            string Type = Console.ReadLine();
            Console.WriteLine("Enter Car's price");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Car's model");
            string Model = Console.ReadLine();
            Console.WriteLine("Enter Car's number"); ;
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Car's color");
            string Color = Console.ReadLine();
            Console.WriteLine("Start the car");
            bool Engine = Convert.ToBoolean(Console.ReadLine());
            Car car = new Car(Make, Year, Type, Price, Model, Number, Color, Engine);
            Console.WriteLine(car.fullInfo());
            car.startAndStop();

            BMW bmw = new BMW();
            Console.WriteLine(bmw.fullInfo());

            bmw.startAndStop();

        }
    }
}
