using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5, Color.Red);
            //Console.WriteLine($"Длина стороны квадрата: {square.Side}");
            //Console.WriteLine($"Площадь квадрата: {square.GetArea()}");
            //Console.WriteLine($"Периметр квадрата: {square.GetPerimeter()}");
            //square.Draw();
            square.Info();

            IntPtr hwnd = GetConsoleWindow(); //Получаем окно консоли
            Graphics graphics = Graphics.FromHwnd(hwnd); 
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle //Получаем прямоугольник окна консоли
                (
                Console.WindowLeft, Console.WindowTop,
                Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            Pen pen = new Pen(Color.Red, 5);
            e.Graphics.DrawRectangle(pen, 100, 100, 500, 500);
            Square square = new Square(50, 200, 200, 1, Color.Red);
            square.Info(e);
            Rectangle rectangle = new Rectangle(200, 150, 400, 200, 2, Color.LemonChiffon);
            rectangle.Info(e);

            Circle circle = new Circle(150, 500, 100, 3, Color.LawnGreen);
            circle.Info(e);

            EquilateralTriangle equilateral = new EquilateralTriangle(100, 800, 300, 5, Color.DarkSalmon);
            equilateral.Info(e);
            IsoscalesTriangle isoscales = new IsoscalesTriangle(100, 70, 800, 100, 1, Color.DarkBlue);
            isoscales.Info(e);
                
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
    }
}
