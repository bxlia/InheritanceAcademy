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
        public Student(AcademyMember academyMember, string group,
            double rating, double attendance) :base(academyMember)
        {
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SHopyConstructor:\t{GetHashCode()}");
        }
        public Student(Student other):base(other)
        {
            this.Group = other.Group;
            this.Rating = other.Rating;
            this.Attendance = other.Attendance;
            Console.WriteLine($"SCopyConstructor:\t{GetHashCode()}");
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
