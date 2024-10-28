namespace Restaurant
{
    public class StartUp
    {
        static void Main()
        {
            var coffee = new Coffee("Espresso", 12);
            var tea = new Tea("Green Tea", 2.50m, 200);
            var cake = new Cake("Chocolate Cake");
            var fish = new Fish("Salmon", 15.00m);

            Console.WriteLine($"Beverage: {coffee.Name}, Price: {coffee.Price}, Milliliters: {coffee.Milliliters}, Caffeine: {coffee.Caffeine}");
            Console.WriteLine($"Beverage: {tea.Name}, Price: {tea.Price}, Milliliters: {tea.Milliliters}");
            Console.WriteLine($"Food: {cake.Name}, Price: {cake.Price}, Grams: {cake.Grams}, Calories: {cake.Calories}");
            Console.WriteLine($"Food: {fish.Name}, Price: {fish.Price}, Grams: {fish.Grams}");
        }
    }
}