using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _30_6_2024
{
    public class Person
    {
       public int Age;
        public string Gender;
        public string Name;
        public string Email;
        public int ID;
        public string Phone;

        public Person()
        {
            Age = 18;
            Name = "Mera";
            Email = "meraoudat123@gmail.com";
            ID = 230008;
            Phone = "0790556241";
        }

        public Person(int age, string gender,string name, string email, int id, string phone)
        {
            if(age>=18&& age <= 60)
            {
                Age = age;
            }
            Gender = gender;
            Email= email;
            ID= id; 
            if (IsValidPhoneNumber(phone))
            {
                Phone = phone;
            }
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            
            return phoneNumber.StartsWith("077") || phoneNumber.StartsWith("078") || phoneNumber.StartsWith("079");
        }

        public void display()
        {
            Console.WriteLine($"Age: {Age}, Gender: {Gender}, Email: {Email}, ID: {ID}, Phone:{Phone}");
        }

    }
}
