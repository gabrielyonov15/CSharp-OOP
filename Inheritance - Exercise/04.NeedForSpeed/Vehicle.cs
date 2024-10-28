using NeedForSpeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumptionValue = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public virtual double DefaultFuelConsumption => DefaultFuelConsumptionValue;
        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; protected set; }
        public int HorsePower { get; }
        public virtual void Drive(double kilometers)
        {
            double fuelNeeded = kilometers * FuelConsumption;
            if (Fuel >= fuelNeeded)
            {
                Fuel -= fuelNeeded;
            }
        }
    }
    public class Car : Vehicle
    {
        private const double CarFuelConsumption = 3;
        public Car(int horsePower, double fuel) : base(horsePower, fuel) { }
        public override double DefaultFuelConsumption => CarFuelConsumption;
        public override double FuelConsumption => DefaultFuelConsumption;
    }
    public class Motorcycle : Vehicle
    {
        public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel) { }
    }
    public class RaceMotorcycle : Motorcycle
    {
        private const double MotorcycleFuelConsumption = 8;
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel) { }
        public override double DefaultFuelConsumption => MotorcycleFuelConsumption;
        public override double FuelConsumption => DefaultFuelConsumption;
    }
    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel) { }
    }
    public class SportCar : Car
    {
        private const double SportCarFuelConsumption = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel) { }
        public override double DefaultFuelConsumption => SportCarFuelConsumption;
        public override double FuelConsumption => DefaultFuelConsumption;
    }
    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel) { }
    }
}