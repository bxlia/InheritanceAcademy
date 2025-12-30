using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
    internal class Bathyscaphe:UnderWater
    {
        public override void Move()
        {
            Console.WriteLine("Умеет погружаться под воду");

        }
    }
}
