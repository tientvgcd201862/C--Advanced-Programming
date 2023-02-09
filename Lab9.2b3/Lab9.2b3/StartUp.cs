using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2b3
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2,4);
            Circle circle = new Circle(4);
            System.Console.WriteLine(rectangle.CalculatePerimeter());
            System.Console.WriteLine(rectangle.CalculateArea());
            System.Console.WriteLine(circle.CalculatePerimeter());
            System.Console.WriteLine(circle.CalculateArea());
        }
    }
}
