using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class AcademyMember:Human
    {
        public string Speciality { get; set; }
        public AcademyMember(string lastname, string firstname, int age, string speciality):base(lastname, firstname, age)
        {
            //Конструктор  дочернего класса кроме своих собственных 
            //полей, также в обязательно порядке должен принимать поля
            //своих родителей
            this.Speciality = speciality;
            Console.WriteLine($"AMConstructor:\t{GetHashCode()}");
        }
        public AcademyMember(Human human, string speciality):base(human)
        {
            this.Speciality = speciality;
        }
        public AcademyMember(AcademyMember other):base(other)
        {
            this.Speciality = other.Speciality;
            Console.WriteLine($"AMCopyConstructor:\t{GetHashCode()}");
        }
        ~AcademyMember()
        {
            Console.WriteLine($"AMDestructor:\t{GetHashCode()}");
        }
        public override Human Init(string[] values)
        {
            base.Init(values);
            Speciality = values[4];
            return this;
        }
        public override void Info()
        {
            base.Info();    //Ключевое слово 'base' означает непосредственно родителя
            Console.WriteLine(Speciality);

           
          
        }
        public override string ToString()
        {
            return base.ToString()+Speciality.PadRight(12);
        }
        public override string ToFileString()
        {
            return base.ToFileString() + $",{Speciality}";
        }
    }
}
