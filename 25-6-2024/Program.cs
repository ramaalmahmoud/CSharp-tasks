

using System;

namespace CSharp_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.Write("1-Enter any word:  ");
            word =Console.ReadLine();
            Console.WriteLine(word);
            Console.WriteLine("2- variables :");
            double num1 = 2.4;
            string name = "Rama";
            char letter= 'A';
            bool isValid= false;
            int num2 = 4;
            const int num3 = 5;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
Console.WriteLine(name);
            Console.WriteLine(letter);
            Console.WriteLine(isValid);
            Console.WriteLine(num3);


            Console.WriteLine("3- array");
            string[] car = { "Ford", "Hundi", "Nissan" };
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            Console.WriteLine("The length of array is "+ car.Length);



            Console.WriteLine("4- Information");
            Console.Write(	"Input your firstname:");
            string firstName = Console.ReadLine();
            Console.Write("Input your lastname:");
            string lastName = Console.ReadLine();
            Console.Write("Input your year of birth:");
            string yearBirth= Console.ReadLine();
            Console.WriteLine(firstName+" "+lastName+" "+yearBirth);

            Console.WriteLine("5- array");
            Console.Write("Input 10 elements in the array :");
            string[] element=new string[10];
            element[0]=Console.ReadLine();
            element[1]=Console.ReadLine();
            element[2]=Console.ReadLine();
            element[3]=Console.ReadLine();
            element[4]=Console.ReadLine();
            element[5]=Console.ReadLine();
            element[6]=Console.ReadLine();
            element[7]=Console.ReadLine();
            element[8]=Console.ReadLine();
            element[9]=Console.ReadLine();
            Console.WriteLine("Elements in array are: " + element[0]+" " + element[1]+" " + element[2] + " " + element[3] + " " + element[4] + " " + element[5] + " " + element[6] + " " + element[7] + " " + element[8] + " " + element[9] + " ");

            Console.WriteLine("6- sum");
            int[] numbers = { 2, 5, 8 };
            int sum = numbers[0] + numbers[1]+numbers[2];
            Console.WriteLine("Sum of all elements stored in the array is : " +sum);




        }
    }
}
