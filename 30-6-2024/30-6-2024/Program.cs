

using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace _30_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //1summation and average
            double[] array = { 1, 2, 3, 4, 5,6, 7, 8, 9, 10 };
            (double sum, double avg)  = summAndaverage(array);
            Console.WriteLine( $"The sum of 10 numbers is {sum} \n The average is {avg}");

            Console.WriteLine();
            Console.WriteLine();

            //2 cube
            Console.WriteLine("Enter the number that you want to find cube for");
            int number =Convert.ToInt32(Console.ReadLine());
            int cubeRes=Cube(number);
            Console.WriteLine($"Number: {number} and cube of the {number} is {cubeRes}");

            Console.WriteLine();
            Console.WriteLine();

            //3 years
            Console.WriteLine("Enrer array  of years");
            int[] arrYears=new int[8];
            for (int i = 0; i < arrYears.Length; i++)
            {
                arrYears[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] y=getYear(arrYears);
            Console.WriteLine("The  years that greater than 1950 is: ");
            for (int i = 0; i < y.Length; i++)
            {
                
                    Console.Write(y[i]+" ");
                
            }
            
            
            Console.WriteLine();
            Console.WriteLine();

            //4 age
            Console.WriteLine("enter your age:");
            double age=Convert.ToDouble(Console.ReadLine());
            double ageRes=Age(age);
            Console.WriteLine($" The age in days is : {ageRes} ");

            Console.WriteLine();
            Console.WriteLine();

            //5
            Console.WriteLine("The default ");
            Person mera = new Person();
            mera.display();
            Console.WriteLine();
            Person person = new Person(10, "f", "rama", "ramaoudat@gmail.com", 778, "0000078");
            Console.WriteLine("person 1");
            person.display();


        }

        //1
        static (double avg, double sum) summAndaverage(double[] array)
        {
            double sum = 0;
            double averg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                averg = sum / array.Length;

            }
            return (sum,averg);
        }
        //2
        static int Cube(int number)
        {
            return number * number * number;
        }

        //3 
        static int[] getYear(int[] years) {
            List<int> yearList = new List<int>();
          
        for (int i = 0;i < years.Length;i++) {
                if (years[i] > 1950)
                {
                    yearList.Add( years[i]);
                    

                }

                }
            return yearList.ToArray();
       
        }

        //4
        static double Age(double age) { 
        return (age * 365)+(age/4)-(age/100)+(age/400) ;
        }


     
        
        
        }
}
