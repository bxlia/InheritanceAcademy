using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:AcademyMember
    {
        public int Experience { get; set; }
        public Teacher(string lastname, string firstname, int age, string speciality, int experience) : base(lastname, firstname, age, speciality)
        {
            Experience = experience;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode()}");
        }
        public override Human Init(string[] values)
        {
            base.Init(values);
            Experience = Convert.ToInt32(values[5]);
            return this;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine(Experience);
        }
        public override string ToString()
        {
            return base.ToString() + Experience.ToString().PadRight(5);
        }
        public override string ToFileString()
        {
            return base.ToFileString()+$",{Experience}";
        }
    }
}
