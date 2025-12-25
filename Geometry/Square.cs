using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    internal class Square:Shape
    {
        public double Side { get; set; }
        public Square(double side, Color color):base(color)
        {
            this.Side = side;
        }
        public override double GetArea() => Side * Side;
        public override double GetPerimeter() => Side * 4;
        public override void Draw()
        {
            for (int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public override void Info()
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Длина стороны квадрата: {Side}");
            base.Info();
        }
        
    }
}
