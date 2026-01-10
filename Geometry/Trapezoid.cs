using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    abstract internal class Trapezoid
    {
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int LineWIdth { get; set; }
        public Color Color { get; set; }

        public Trapezoid(int startX, int startY, int lineWidth, Color color)
        {
            StartX = startX;
            StartY = startY;
            LineWIdth = lineWidth;
            Color = color;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw(PaintEventArgs e);

        public virtual void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Площадь: {GetArea():F2}");
            Console.WriteLine($"Периметр: {GetPerimeter():F2}");
        }
    }
}