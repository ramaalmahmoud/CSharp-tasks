using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _26_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please Enter a string");
            //string s1= Console.ReadLine();
            // Console.WriteLine(s1);
            // Console.WriteLine(s1[s1.Length - 1]);
            // Console.WriteLine("Please Enter a string");
            // string s2 = Console.ReadLine();
            // Console.WriteLine("Please Enter another string");


            // string s3 = Console.ReadLine();
            // Console.WriteLine(s2+" "+s3);

            // string s4 = "hello world";
            // Console.WriteLine(s4.Substring(2,2));

            //1
            //Console.WriteLine("1- smaller number");
            //Console.WriteLine("Enter a number");
            //int num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The smaller number is: "+Math.Min(num1,num2));



            ////2
            //Console.WriteLine("2- The sign");
            //Console.WriteLine("Enter a number");
            //int n1 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("The sign of the number is: "+Math.Sign(n1));

            ////3
            //Console.WriteLine("3- sort numbers");
            //Console.WriteLine("Enter 3 numbers");
            //int a1=Convert.ToInt32(Console.ReadLine());
            //int b1=Convert.ToInt32(Console.ReadLine());
            //int c1=Convert.ToInt32(Console.ReadLine());
            //int[] nums ={ a1,b1,c1 };
            //Array.Sort(nums);
            //Array.Reverse(nums);
            //Console.WriteLine(String.Join(" ", nums));

            ////4
            //Console.WriteLine("4-The max number");
            //Console.WriteLine("Enter 5 numbers");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //int number4= Convert.ToInt32(Console.ReadLine());
            //int number5= Convert.ToInt32(Console.ReadLine());
            //int[] numbers={number1,number2,number3,number4,number5 };
            //Array.Sort (numbers);
            //Console.WriteLine("The max number is: " + numbers[numbers.Length-1]);

            ////5
            //Console.WriteLine("5- Convert kilometers: ");
            //Console.WriteLine("Enter kelometer number: ");
            //double kilometer = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(0.621371192*kilometer+"mile per hour");

            //6
           // Console.WriteLine("6- Calculate the total number of minutes: ");
           // Console.WriteLine("enter hours and minutes");
           //int hour=Convert.ToInt32(Console.ReadLine());
           // int minute=Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine($"Total minutes {hour*60+minute}");

           // //7
           // Console.WriteLine("7- Convert hours to minutes: ");
           // Console.WriteLine(" Enter minutes: ");
           // double m=Convert.ToDouble(Console.ReadLine());
           // double minutes= 0.0166667 *m;
           // int hours =(int)  minutes;
           // int minutes2 = (int) m%60;
           // Console.WriteLine($"{hours} Hours, {minutes2} Minutes");

            //8
            Console.WriteLine("8- String: ");
            string[] strings = new string[5] {"Rama "," biomedical engineer "," 24 old"," I love music"," Full stack developer"};
            string s0=strings[0];
            string s1 = strings[1];
            string s2 = strings[2];
            string s3 = strings[3];
            string s4 = strings[4];
            Console.WriteLine(s0+s1+s2+s3+s4);
            Console.WriteLine(s0.Substring(0, 5) + s1.Substring(0, 5) + s2.Substring(0, 5) + s3.Substring(0, 5) + s4.Substring(0, 5));








        }
    }
}
