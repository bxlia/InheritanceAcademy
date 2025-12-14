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
        ~AcademyMember()
        {
            Console.WriteLine($"AMDestructor:\t{GetHashCode()}");
        }
        public void Info()
        {
            base.Info();    //Ключевое слово 'base' означает непосредственно родителя
            Console.WriteLine(Speciality);

           
          
        }
    }
}
