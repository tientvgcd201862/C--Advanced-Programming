using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    internal class Motorcycle : Vehicle
    {
        public new static double DefaultFuelConsumption = 1.5;
        public override double FuelConsumption { get; set; } = DefaultFuelConsumption;

        public Motorcycle()
        {

        }

        public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}
