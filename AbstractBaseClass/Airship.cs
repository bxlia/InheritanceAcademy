using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
    internal class Airship:AirVehicle
    {
        public override void Move()
        {
            Console.WriteLine("Летает, имеет массивный шар");

        }
    }
}
