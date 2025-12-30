using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class Circle:Shape
    {
        float radius;
        public float Radius
            { get { return radius; } set { radius = value; } }
        public Circle(float radius, int startX, int startY, int lineWidth, System.Drawing.Color color) :
            base(startX, startY, lineWidth, color)
                {
                this.Radius = radius;
                }
        public override double GetArea()=> Math.PI * Math.Pow(Radius, 2);
        public override double GetPerimeter()=> 2*Math.PI * Radius;
        public override void Draw(PaintEventArgs e) =>
            e.Graphics.DrawEllipse(new System.Drawing.Pen(Color, LineWIdth), StartX, StartY, 2*Radius, 2*Radius);

        
        
        }
    }
}
