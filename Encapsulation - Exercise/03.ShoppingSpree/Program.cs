using System;

namespace _03.ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                var productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                var people = new Dictionary<string, Person>();
                foreach (var p in peopleInput)
                {
                    var parts = p.Split('=');
                    var name = parts[0];
                    var money = decimal.Parse(parts[1]);
                    people[name] = new Person(name, money);
                }
                var products = new Dictionary<string, Product>();
                foreach (var p in productInput)
                {
                    var parts = p.Split('=');
                    var name = parts[0];
                    var cost = decimal.Parse(parts[1]);
                    products[name] = new Product(name, cost);
                }
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var parts = command.Split();
                    var personName = parts[0];
                    var productName = parts[1];
                    if (people.ContainsKey(personName) && products.ContainsKey(productName))
                    {
                        people[personName].BuyProduct(products[productName]);
                    }
                }
                foreach (var person in people.Values)
                {
                    string boughtProducts = person.BagOfProducts.Count > 0
                        ? string.Join(", ", person.BagOfProducts)
                        : "Nothing bought";
                    Console.WriteLine($"{person.Name} - {boughtProducts}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}