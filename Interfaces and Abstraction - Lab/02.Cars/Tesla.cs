using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; }
        public string Color { get; }
        public int Battery { get; }
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Start() => "Engine start";
        public string Stop() => "Breaaak!";
        public override string ToString() => $"{Color} Tesla {Model} with {Battery} Batteries";
    }
}