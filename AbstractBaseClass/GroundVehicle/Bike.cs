using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
    abstract internal class Bike : OnRoad
    {
        public override void Move()
        {
            Console.WriteLine($"Ездит на двух колесах, может перевозить не более 3 человек");

        }
        
    }
}
