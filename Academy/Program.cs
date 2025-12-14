//#define INHERITANCE_1
//#define INHERITANCE_2
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
#if INHERITANCE_1
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
#endif
#if INHERITANCE_2

            Human human = new Human("Чухарев", "Матвей", 16);
            human.Info();
            Console.WriteLine(delimiter);

            AcademyMember academyMember = new AcademyMember(human, "РПО");
            academyMember.Info();
            Console.WriteLine(delimiter);

            Student student = new Student(academyMember, "P_421", 90, 95);
            student.Info();
            Console.WriteLine(delimiter);

            Graduate graduate = new Graduate(student, "Разработка приложения для междунаподной доставки");
            graduate.Info();
            Console.WriteLine(delimiter);
#endif
        }
    }
}
