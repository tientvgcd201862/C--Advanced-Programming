namespace Hw1_9._2
{
    internal class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm): base(fuelQuantity, litersPerKm + 1.6)
        {

        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}