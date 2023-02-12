namespace Hw1_9._2
{
    internal class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm)
        : base(fuelQuantity, litersPerKm + 0.9)
        {

        }
    }
}