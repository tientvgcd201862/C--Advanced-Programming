using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2b3
{
    internal class Rectangle:Shape
    {
        double width;
        double height;
        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        
        public override double CalculatePerimeter()
        {
            return (width + height) * 2;
        }
        public override double CalculateArea()
        {
            return width * height;
        }
    }
}
