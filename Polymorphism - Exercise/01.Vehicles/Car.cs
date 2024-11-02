using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditionerConsumption = 0.9;
        public Car(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm + AirConditionerConsumption) { }
        public override void Drive(double distance)
        {
            double requiredFuel = LitersPerKm * distance;
            if (requiredFuel <= FuelQuantity)
            {
                FuelQuantity -= requiredFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }
        public override void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
    }
}