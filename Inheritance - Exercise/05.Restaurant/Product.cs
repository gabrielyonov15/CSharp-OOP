using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters)
            : base(name, price)
        {
            Milliliters = milliliters;
        }
        public double Milliliters { get; set; }
    }
    public class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters)
            : base(name, price, milliliters) { }
    }
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters)
            : base(name, price, milliliters) { }
    }
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50M;
        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
        public double Caffeine { get; set; }
    }
    public class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double milliliters)
            : base(name, price, milliliters) { }
    }
    public class Food : Product
    {
        public Food(string name, decimal price, double grams)
            : base(name, price)
        {
            Grams = grams;
        }
        public double Grams { get; set; }
    }
    public class MainDish : Food
    {
        public MainDish(string name, decimal price, double grams)
            : base(name, price, grams) { }
    }
    public class Dessert : Food
    {
        public Dessert(string name, decimal price, double grams, double calories)
            : base(name, price, grams)
        {
            Calories = calories;
        }
        public double Calories { get; set; }
    }
    public class Starter : Food
    {
        public Starter(string name, decimal price, double grams)
            : base(name, price, grams) { }
    }
    public class Fish : MainDish
    {
        private const double Grams = 22;
        public Fish(string name, decimal price)
            : base(name, price, Grams) { }
    }
    public class Soup : MainDish
    {
        public Soup(string name, decimal price, double grams)
            : base(name, price, grams) { }
    }
    public class Cake : Dessert
    {
        private const double Grams = 250;
        private const double Calories = 1000;
        private const decimal CakePrice = 5;
        public Cake(string name)
            : base(name, CakePrice, Grams, Calories) { }
    }
}