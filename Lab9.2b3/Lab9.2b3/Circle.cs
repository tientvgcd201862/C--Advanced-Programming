using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2b3
{
    internal class Circle:Shape
    {
        private double radius;

        public double Radius { get;set; }

        public Circle(int radius)
        {
            this.radius = radius;
        }


        public override double CalculateArea()
        {
            return 2 * radius * System.Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return radius * radius * System.Math.PI;
        }
    }
}
