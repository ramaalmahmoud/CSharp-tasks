using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_2024
{
    internal class Program
    { public interface ISound
        {
            void MakeSound();
        }

        public abstract class Animal:ISound
        {
            public string Name { get; set; }
            protected Animal(string name)
            {
                Name = name;
            }

            public abstract void Eat();
           public void Sleep()
            {
                Console.WriteLine($"{Name} is sleeping");
            }

            public void MakeSound()
            {
                Console.WriteLine("The animal make sound");
            }
        }

        class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }

            public override void Eat()
            {
                Console.WriteLine($" {Name} eat meat");
            }
            public void MakeSound()
            {
                Console.WriteLine($" {Name} make Woof!");
            }
        }

        class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }

            public override void Eat()
            {
                Console.WriteLine($" {Name} eat fish");
            }
            public void MakeSound()
            {
                Console.WriteLine($" {Name} make Meow!");
            }
        }
        static void Main(string[] args)
        {

            Dog dog = new Dog("Seemaa");
            dog.MakeSound();
            dog.Eat();
            dog.Sleep();

            Cat cat = new Cat("Aless");
            cat.MakeSound();
            cat.Eat();
            cat.Sleep();


        }
    }
}
