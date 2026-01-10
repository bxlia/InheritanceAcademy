using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    abstract internal class Triangle : Shape, IHaveHeight
    {
        public Triangle(int startX, int startY, int lineWidth, Color color)
            : base(startX, startY, lineWidth, color)
        {
        }

        public abstract double GetHeight();
        public abstract void DrawHeight(PaintEventArgs e);

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Высота треугольника: {GetHeight():F2}");
            base.Info(e);
        }
    }

    internal class EquilateralTriangle : Triangle
    {
        private float side;

        public float Side
        {
            get => side;
            set => side = FilterSize(value);
        }

        public EquilateralTriangle(float side, int startX, int startY, int lineWidth, Color color)
            : base(startX, startY, lineWidth, color)
        {
            this.side = side;
        }

        public override double GetHeight() => Math.Sqrt(side * side - (side / 2) * (side / 2));
        public override double GetArea() => side * GetHeight() / 2;
        public override double GetPerimeter() => side * 3;

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWIdth);
            Point[] points =
            {
                new Point(StartX, (int)(StartY + GetHeight())),
                new Point((int)(StartX + side), (int)(StartY + GetHeight())),
                new Point((int)(StartX + side / 2), StartY)
            };
            e.Graphics.DrawPolygon(pen, points);
        }

        public override void DrawHeight(PaintEventArgs e)
        {
            Pen heightPen = new Pen(Color.Red, 1);
            float height = (float)GetHeight();
            float topX = StartX + side / 2;
            float topY = StartY;
            float baseX = StartX + side / 2;
            float baseY = StartY + height;
            e.Graphics.DrawLine(heightPen, topX, topY, baseX, baseY);
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Длина: {side}");
            base.Info(e);
        }
    }

    internal class IsoscelesTriangle : Triangle
    {
        private float baseLength;
        private float equalSide;

        public float BaseLength
        {
            get => baseLength;
            set => baseLength = FilterSize(value);
        }

        public float EqualSide
        {
            get => equalSide;
            set => equalSide = FilterSize(value);
        }

        public IsoscelesTriangle(float baseLength, float equalSide, int startX, int startY, int lineWidth, Color color)
            : base(startX, startY, lineWidth, color)
        {
            this.baseLength = baseLength;
            this.equalSide = equalSide;
        }

        public override double GetHeight() => Math.Sqrt(equalSide * equalSide - (baseLength / 2) * (baseLength / 2));
        public override double GetArea() => baseLength * GetHeight() / 2;
        public override double GetPerimeter() => baseLength + 2 * equalSide;

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWIdth);
            float height = (float)GetHeight();
            Point[] points =
            {
                new Point(StartX, (int)(StartY + height)),
                new Point((int)(StartX + baseLength), (int)(StartY + height)),
                new Point((int)(StartX + baseLength / 2), StartY)
            };
            e.Graphics.DrawPolygon(pen, points);
        }

        public override void DrawHeight(PaintEventArgs e)
        {
            Pen heightPen = new Pen(Color.Red, 1);
            float height = (float)GetHeight();
            float topX = StartX + baseLength / 2;
            float topY = StartY;
            float baseX = StartX + baseLength / 2;
            float baseY = StartY + height;
            e.Graphics.DrawLine(heightPen, topX, topY, baseX, baseY);
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Основание: {baseLength}");
            Console.WriteLine($"Сторона: {equalSide}");
            base.Info(e);
        }
    }

    internal class RightTriangle : Triangle
    {
        private float cathet1;
        private float cathet2;

        public float Cathet1
        {
            get => cathet1;
            set => cathet1 = FilterSize(value);
        }

        public float Cathet2
        {
            get => cathet2;
            set => cathet2 = FilterSize(value);
        }

        public RightTriangle(float cathet1, float cathet2, int startX, int startY, int lineWidth, Color color)
            : base(startX, startY, lineWidth, color)
        {
            this.cathet1 = cathet1;
            this.cathet2 = cathet2;
        }

        public double Hypotenuse => Math.Sqrt(cathet1 * cathet1 + cathet2 * cathet2);
        public override double GetHeight() => (cathet1 * cathet2) / Hypotenuse;
        public override double GetArea() => cathet1 * cathet2 / 2;
        public override double GetPerimeter() => cathet1 + cathet2 + Hypotenuse;

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWIdth);
            Point[] points =
            {
                new Point(StartX, StartY),
                new Point(StartX + (int)cathet1, StartY),
                new Point(StartX, StartY + (int)cathet2)
            };
            e.Graphics.DrawPolygon(pen, points);
        }

        public override void DrawHeight(PaintEventArgs e)
        {
            Pen heightPen = new Pen(Color.Red, 1);
            float h = (float)GetHeight();
            float baseX = StartX;
            float baseY = StartY;
            float endX = StartX + (float)(h * cathet2 / Hypotenuse);
            float endY = StartY + (float)(h * cathet1 / Hypotenuse);
            e.Graphics.DrawLine(heightPen, baseX, baseY, endX, endY);
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Катет: {cathet1}");
            Console.WriteLine($"Катет: {cathet2}");
            Console.WriteLine($"Гипотенуза: {Hypotenuse:F2}");
            base.Info(e);
        }
    }
}