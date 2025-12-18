//#define INHERITANCE_1
//#define INHERITANCE_2
//#define POLYMORPHISM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;
using System.Linq.Expressions;

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
#if POLYMORPHISM
            Human[] group =
            {
                new Graduate("Чухарев", "Матвей", 16, "РПО", "P_421", 95, 97, "Разработка приложения для службы доставки"),
                new Teacher("Hoffman", "Wolf", 35, "Guitars", 15),
                new Teacher("Heriksson", "Matrin", 32, "Bass guitar", 12),
                new Student("Гусев", "Савелий", 15, "РПО", "P_421", 90, 95),
                new Student("Абдрашитов", "Булат", 16, "РПО", "P_421", 98, 99),
                new Specialist("Гусев", "Константин", 16, "РПО", "P_421", 95, 97, "Файловые менеджеры ", 12)
            };
            for (int i = 0; i < group.Length; i++)
            {
                //group[i].Info();
                Console.WriteLine(group[i]);
                Console.WriteLine(delimiter);
            }

            Print(group);
            Save(group, "P_421.csv");
            Directory.SetCurrentDirectory("..\\..");
            /*
             * . - ссылка на текущий катлог;
             * .. - ссылка на родительский каталог;
             * */
            Console.WriteLine(Directory.GetCurrentDirectory());
            //1) Создаем поток:
            //string filename = "P_421.txt";
            StreamWriter writer = new StreamWriter(filename);//Поток автоматически открывается при создании
            //2) Выполняем запись в поток:
            for (int i = 0; i < group.Length; i++)
            {
                writer.WriteLine(group[i].ToFileString() + ";");//Всё что записывается в поток попадает в файл этого потока
            }
            //3)Потоки обязательно нужно закрывать:
            writer.Close();

            Process.Start("notepad", filename);
#endif

            Human[] group = Load("P_421.csv");
            Print(group);
            Console.WriteLine("end");
        }
        static void Print(Human[] group)
        {
            Console.WriteLine(delimiter);
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]);
            }
            Console.WriteLine(delimiter);
        }
        static void Save(Human[] group, string filename)
        {

        }
        static Human[] Load(string filename)
        {
            List<Human> group = new List<Human>();
            try
            {
                Directory.SetCurrentDirectory("..\\..");
                StreamReader reader = new StreamReader(filename);
                Factory factory = new Factory();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    //Console.WriteLine(line);
                    String[] values = line.Split(":,;".ToCharArray());
                    //for (int i = 0; i < strings.Length; i++) Console.Write($"{strings[i]}\t");
                    Console.WriteLine();
                    group.Add(factory.Create(values[0]).Init(values));
                }
                reader.Close();
            }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            return group.ToArray();
        }
    }
}
