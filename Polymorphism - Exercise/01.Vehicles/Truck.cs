using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirConditionerConsumption = 1.6;
        private const double FuelRetentionPercentage = 0.95;
        public Truck(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm + AirConditionerConsumption) { }
        public override void Drive(double distance)
        {
            double requiredFuel = LitersPerKm * distance;
            if (requiredFuel <= FuelQuantity)
            {
                FuelQuantity -= requiredFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }
        public override void Refuel(double liters)
        {
            FuelQuantity += liters * FuelRetentionPercentage;
        }
    }
}