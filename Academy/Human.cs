using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Human(string lastname, string firstname, int age)
        {
            LastName = lastname;
            FirstName = firstname;
            Age = age;
            Console.WriteLine($"HConstructor:{GetHashCode()}");
        }
        ~Human()
            {
                Console.WriteLine($"HConstructor:{GetHashCode()}");
            }
        public void Info()
        {
            Console.WriteLine($"{LastName} {FirstName} {Age}");
        }
    }
}
