﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_2024
{
    internal class BMW:Car
        
    {
        public BMW()
        {
            
        }
        public BMW(string make, int year, string type, int price, string model, int number, string color, bool engine) : base( make,  year,  type,  price,  model,  number,  color,  engine)
        {
            
        }

        public void Display()
        {
            Console.WriteLine("Welcome BMW");
        }

        public override void go()
        {
            Console.WriteLine("The BMW is moving");

        }
    }
}
