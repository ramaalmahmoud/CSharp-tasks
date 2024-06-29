using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _27_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Triangle
            //for(int i=0; i<10; i++)
            //{
            //    for(int j=0; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            // 1
            Console.WriteLine("1-Correct the syntax error:");
            string[] ARR = { "1", "7", "9", "45" }; // the elements of the array must be string type and inside curly brackets and commas between all elements
            string[] arr2 = { "Str", "alex", "moh" };// the data typy must be string and the variable must declared as array and elements inside curly bracekts and commas between all elements
            string[] arr3 = { "the", "fox" ,"over", "lazy", "dog",};// The elements must be inside curly brackets  and each string must be in a double qoutation, the variable must declared as array and commas between all elements


            //2
            Console.WriteLine("2-The index of  \"Banana\",\"Tomato\"? :");
            string[] fruits = {"Tomato", "Banana", "Watermelon" };
            Console.WriteLine($"Tomato in index:{Array.IndexOf(fruits,"Tomato")}");
            Console.WriteLine($"Banana in index:{Array.IndexOf(fruits, "Banana")}");

            //a
            Console.WriteLine("Create an multiple array:");
            string[] food = { "Yalanji", "Mansaf", "Maqlouba", "Stuffed zucchini", "Shishbarak" };
            string[] sports = {"Cardio","Swimming","Running" };
            string[] movies = { "The Shawshank Redemption ", "Spider-Man", "Midnight in Paris", "Annie Hall" };

            Console.WriteLine("My Favorite Food : ");
            for (int i = 0; i < food.Length; i++) {
                Console.WriteLine(food[i]);

            };

            Console.WriteLine("My Favorite Sports : ");
            foreach(string s in sports) Console.WriteLine(s);

            Console.WriteLine("My Favorite Movies : ");
            foreach(string m in movies) Console.WriteLine(m);


      //3
      Console.WriteLine("3-the sum of three numbers:");
      Console.WriteLine("Enter three numbers");

            int sum = 0;
            string[] values = Console.ReadLine().Split(',');
            int[] numbers =new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
               

                numbers[i] = Convert.ToInt32(values[i]);
                sum += numbers[i];


            }
            Console.WriteLine($"The summation of your numbers is {sum}");


            //4
            Console.WriteLine("4-the sum of odd numbers:");
            int sumOdds = 0;
            Console.Write($"The odd numbers are    ");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sumOdds += i;
                    int[] oddNum = { i };
                    Console.Write(i+" ");

                }
               
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The Sum of odd Numbers is {sumOdds}");


            //5
            Console.WriteLine("5-The triangle pattern:");
            
            for (int i = 0; i < 4; i++)
            {

                

                for (int j = 0; j <=i; j++)
                {
                    

                    Console.Write("*");
                   

                }

                

                Console.WriteLine();
                Console.WriteLine();
                
            }

            //6
            Console.WriteLine("6-The triangle pattern using numbers:");
            int patt = 1;

            for (int i = 1; i <= 4; i++)
            {



                for (int j = 1; j<= i; j++)
                {

                    Console.Write(patt+" ");
                    patt++;




                }



                Console.WriteLine();
                Console.WriteLine();

            }





        }
    }
}
