using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    internal class Parallelogram : Shape
    {
        private float baseLength;
        private float side;
        private float angle;

        public float BaseLength
        {
            get => baseLength;
            set => baseLength = FilterSize(value);
        }

        public float Side
        {
            get => side;
            set => side = FilterSize(value);
        }

        public float Angle
        {
            get => angle;
            set => angle = value % 180;
        }

        public Parallelogram(float baseLength, float side, float angle, int startX, int startY, int lineWidth, Color color)
            : base(startX, startY, lineWidth, color)
        {
            this.baseLength = baseLength;
            this.side = side;
            this.angle = angle;
        }

        public double GetHeight() => side * Math.Sin(angle * Math.PI / 180);
        public override double GetArea() => baseLength * GetHeight();
        public override double GetPerimeter() => 2 * (baseLength + side);

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWIdth);
            float height = (float)GetHeight();
            float offset = (float)(side * Math.Cos(angle * Math.PI / 180));
            Point[] points =
            {
                new Point(StartX, StartY),
                new Point(StartX + (int)offset, (int)(StartY - height)),
                new Point(StartX + (int)(baseLength + offset), (int)(StartY - height)),
                new Point(StartX + (int)baseLength, StartY)
            };
            e.Graphics.DrawPolygon(pen, points);
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Основание: {baseLength}");
            Console.WriteLine($"Длина: {side}");
            Console.WriteLine($"Угол: {angle}°");
            Console.WriteLine($"Высота: {GetHeight():F2}");
            base.Info(e);
        }
    }
}
