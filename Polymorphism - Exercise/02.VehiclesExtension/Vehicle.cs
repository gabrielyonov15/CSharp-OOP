using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double LitersPerKm { get; protected set; }
        public double TankCapacity { get; private set; }
        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            LitersPerKm = litersPerKm;
        }
        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
        protected bool CanFitFuel(double liters)
        {
            return FuelQuantity + liters <= TankCapacity;
        }
    }
}