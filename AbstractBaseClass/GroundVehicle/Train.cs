using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
    internal class Train:OnRaills
    {
        public override void Move()
        {
            Console.WriteLine("Поезд ездит по рельсам на большие расстояния, может перевозить людей или груз");

        }
    }
}
