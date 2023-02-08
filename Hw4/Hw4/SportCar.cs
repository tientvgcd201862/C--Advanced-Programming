using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    internal class SportCar : Car
    {
        public new static double DefaultFuelConsumption = 10;
        public override double FuelConsumption { get; set; } = DefaultFuelConsumption;
        public SportCar()
        {

        }

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}
