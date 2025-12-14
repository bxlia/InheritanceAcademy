using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Student:AcademyMember
    {
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        public Student(string lastname, string firstname, int age, string speciality, string group, double rating, double attendance) : base(lastname, firstname, age, speciality)
        {
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
        ~Student()
        {
           Console.WriteLine($"SDestructor:\t{GetHashCode()}");
        }
        public void Info()
        {
            base.Info();
            Console.WriteLine($"{Group}{Rating}{Attendance}");
        }
    }
}
