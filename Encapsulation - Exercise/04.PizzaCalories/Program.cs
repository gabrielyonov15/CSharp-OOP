public class Program
{
    public static void Main()
    {
        try
        {
            string[] pizzaData = Console.ReadLine().Split();
            string pizzaName = pizzaData[1];
            Pizza pizza = new Pizza(pizzaName);
            string[] doughData = Console.ReadLine().Split();
            string flourType = doughData[1];
            string bakingTechnique = doughData[2];
            int doughWeight = int.Parse(doughData[3]);
            pizza.Dough = new Dough(flourType, bakingTechnique, doughWeight);
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] toppingData = input.Split();
                string toppingType = toppingData[1];
                int toppingWeight = int.Parse(toppingData[2]);
                Topping topping = new Topping(toppingType, toppingWeight);
                pizza.AddTopping(topping);
            }
            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}