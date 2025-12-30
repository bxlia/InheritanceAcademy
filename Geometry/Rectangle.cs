using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Geometry
{
    internal class Rectangle
    /*{
        float width;
        float height;
        public float Width
        {
            get => width;
            set => width = FilterSize(height);
        }
        public float Heigth
        {
            get => height;
            set => height = FilterSize(value);
        }
        public Rectangle(float width, float height, int startX, int startY, int lineWidth, Color color) :
            base(startX, startY, lineWidth, color)
            {
                this.Width = width;
                this.Height = height;
            }
            public override double GetArea() => Width * Heigth;
            public override double GetPerimeter() => (Width + Heigth)*2;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWIdth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, Width, Height);
        }
        
    }*/
    class Square : Rectangle
    { 
        public Square(float side, int startX, int startY, int lineWidth, Color color):base(side, side, startX, startY,  lineWidth, color)

    }

}
