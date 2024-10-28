using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    public class Person
    {
        public string Name { get; }
        public decimal Money { get; private set; }
        public List<string> BagOfProducts { get; }
        public Person(string name, decimal money)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty");
            if (money < 0)
                throw new ArgumentException("Money cannot be negative");
            Name = name;
            Money = money;
            BagOfProducts = new List<string>();
        }
        public void BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                BagOfProducts.Add(product.Name);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }
}