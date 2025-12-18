using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Academy
{
    internal class Streamer
    {
        const string delimiter = "\n----------------------------------\n";
        static void Print(Human[] group)
        {
            Console.WriteLine(delimiter);
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]);
            }
            Console.WriteLine(delimiter);
        }
        public static void Save(Human[] group, string filename)
        {

        }
        public static Human[] Load(string filename)
        {
            List<Human> group = new List<Human>();
            try
            {
                Directory.SetCurrentDirectory("..\\..");
                Console.WriteLine(Directory.GetCurrentDirectory());
                StreamReader reader = new StreamReader(filename);
                //Factory factory = new Factory();
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
