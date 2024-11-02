using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double AirConditionerConsumption = 1.6;
        private const double FuelRetentionPercentage = 0.95;
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm + AirConditionerConsumption, tankCapacity) { }
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
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (CanFitFuel(liters * FuelRetentionPercentage))
            {
                FuelQuantity += liters * FuelRetentionPercentage;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}