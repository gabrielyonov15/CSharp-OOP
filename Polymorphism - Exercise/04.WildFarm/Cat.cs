﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) { }
        public override void MakeSound() => Console.WriteLine("Meow");
        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                Weight += food.Quantity * 0.30;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}