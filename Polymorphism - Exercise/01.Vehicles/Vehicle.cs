using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double LitersPerKm { get; protected set; }
        public Vehicle(double fuelQuantity, double litersPerKm)
        {
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
        }
        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
    }
}