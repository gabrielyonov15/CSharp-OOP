using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double AirConditionerConsumptionWithPeople = 1.4;
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm, tankCapacity) { }
        public void DriveWithPeople(double distance)
        {
            double requiredFuel = (LitersPerKm + AirConditionerConsumptionWithPeople) * distance;
            if (requiredFuel <= FuelQuantity)
            {
                FuelQuantity -= requiredFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
        public override void Drive(double distance)
        {
            double requiredFuel = LitersPerKm * distance;
            if (requiredFuel <= FuelQuantity)
            {
                FuelQuantity -= requiredFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (CanFitFuel(liters))
            {
                FuelQuantity += liters;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}