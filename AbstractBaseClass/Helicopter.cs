using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
    internal class Helicopter : AirVehicle
    {
        public override void Move()
        {
            Console.WriteLine("Вертолет может летать на месте");

        }
    }
}
