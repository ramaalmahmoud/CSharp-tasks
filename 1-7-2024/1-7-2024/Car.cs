using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_2024
{
    internal class Car
    {
        protected string Make { set; get; }
        protected int Year { set; get; }
        protected string Type { set; get; }
        protected int Price { set; get; }
        protected string Model { set; get; }
        protected int Number { set; get; }
        protected string Color { set; get; }
        protected bool Engine { set; get; }
        

        public Car()
        {
            Make = "Toyota";
            Year = 2022;
            Type = "Sedan";
            Price = 25000;
            Model = "Camry";
            Number = 1234;
            Color = "Red";
            Engine = true;

        }

        public Car(string make, int year, string type, int price, string model, int number, string color, bool engine)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            Number = number;
            Color = color;
            Engine = engine;

        }
        public void startAndStop()
        {
            if (Engine)
            {
                Console.WriteLine("The engine start");

            }
            else
            {
                Console.WriteLine("The engine stop");
                Engine = false;
            }



        }

        public string fullInfo()
        {
            return $"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price}, Model: {Model}, Number: {Number}, Color: {Color}";

        }

        public void DisplayInfo(string make , int year)
        {
            Console.WriteLine($"Make: {Make}");

        }
        public void DisplayInfo(string make)
        {
            Console.WriteLine($"Make:{Make}");

        }
        public void Display()
        {
            Console.WriteLine("Welcome Car");
        }

        public virtual void go()
        {
            Console.WriteLine("The car is moving");

        }


    }
}
