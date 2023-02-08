using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(200, 200);
            vehicle.Drive(10);
            Console.WriteLine(vehicle);
            Car car = new Car(100, 100);
            car.Drive(10);
            Console.WriteLine(car);
            SportCar sportCar = new SportCar(300, 300);
            sportCar.Drive(10);
            Console.WriteLine(sportCar);
            FamilyCar familyCar = new FamilyCar(150, 150);
            familyCar.Drive(10);
            Console.WriteLine(familyCar);
            Motorcycle motorcycle = new Motorcycle(250, 250);
            motorcycle.Drive(10);
            Console.WriteLine(motorcycle);
            CrossMotorcycle crossMotorcycle = new CrossMotorcycle(300, 300);
            crossMotorcycle.Drive(10);
            Console.WriteLine(crossMotorcycle);
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(190, 190);
            raceMotorcycle.Drive(10);
            Console.WriteLine(raceMotorcycle);

        }
    }
}
