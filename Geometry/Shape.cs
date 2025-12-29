using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    abstract internal class Shape
    {
        static readonly int MIN_START_X = 100;
        static readonly int MIN_START_Y = 100;
        static readonly int MAX_START_X = 1000;
        static readonly int MAX_START_Y = 700;
        static readonly int MIN_LINE_WIDTH = 1;
        static readonly int MAX_LINE_WIDTH = 32;
        static readonly int MIN_SIZE = 50;
        static readonly int MAX_SIZE = 550;

        int startX;
        int startY;
        int lineWidth;
        public int StartX
        { get => startX;
        set => startX = value < MIN_START_X ? MIN_START_X :
                value > MAX_START_X ? MAX_START_X : value; }
        public int StartY
        { get => startY;
        set => startY = value < MIN_START_Y ? MIN_START_Y :
                value > MAX_START_Y ? MAX_START_Y : value; }
        public int LineWIdth
        { get => lineWidth;
        set => lineWidth = value < MIN_LINE_WIDTH ? MIN_LINE_WIDTH :
                value > MAX_LINE_WIDTH ? MAX_LINE_WIDTH : value; }
        
        public float FilterSize(float size)
        {
            return size < MIN_SIZE ? MIN_SIZE :
               size > MAX_SIZE ? MAX_SIZE : size;
        }
        public Shape(int startX,  int startY, int lineWidth, Color color)
        {
            this.startX = startX;
            this.startY = startY;
            this.lineWidth = lineWidth;
            this.Color = color;
        }
        public Color Color { get; set; }
        public Shape(Color color)
        {
            this.Color = color;

        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw();
        public virtual void Info()
        {
            Console.WriteLine($"Площадь фигуры: {GetArea()}");
            Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
            Draw();
        }
    }
}
