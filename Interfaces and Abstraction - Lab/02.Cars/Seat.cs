using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; }
        public string Color { get; }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Start() => "Engine start";
        public string Stop() => "Breaaak!";
        public override string ToString() => $"{Color} Seat {Model}";
    }
}