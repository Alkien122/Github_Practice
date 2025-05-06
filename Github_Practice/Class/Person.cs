using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Practice.Class
{
    internal class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age {  get; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string GetFullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(GetFullName());
            Console.WriteLine(Age);
        }

        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
