using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    
    internal class Program
    {
        const string delimiter = "\n----------------------------------\n";
        static void Main(string[] args)
        {
            Human human = new Human("Blackmore", "Rechie", 32);
            human.Info();
            Console.WriteLine(delimiter);

            AcademyMember am = new AcademyMember("Dirkscheider", "Udo", 55, "Vocals");
            am.Info();
            Console.WriteLine(delimiter);

            Student student = new Student("Львов", "Константин", 16, "РПО", "P_421 ", 98, 100 );
            student.Info();

            Teacher teacher = new Teacher("Heriksson", "Martin", 35, "Guitars", 15);
            teacher.Info();

            Graduate graduate = new Graduate("Абдрашитов", "Булат", 16, "РПО", "P_421" , 95, 100,"Симулятор самолета");
            graduate.Info();
            Console.WriteLine(delimiter);
        }
    }
}
