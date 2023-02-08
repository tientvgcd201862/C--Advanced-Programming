﻿namespace Cars
{
    internal class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }



        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public Tesla()
        {

        }
        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} batteries.";
        }

        public void Start()
        {
            Console.WriteLine("Engine start.");
        }

        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }

    }
}