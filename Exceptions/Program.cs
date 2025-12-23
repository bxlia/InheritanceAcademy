using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for(int i=1; i<=n; i++)
            {
                f *= i;
                Console.WriteLine($"{i}! = {f}");
            }
        }
    }
}
