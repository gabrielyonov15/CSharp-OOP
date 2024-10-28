public class Topping
{
    private static readonly Dictionary<string, decimal> ToppingModifiers = new()
    {
        { "meat", 1.2m },
        { "veggies", 0.8m },
        { "cheese", 1.1m },
        { "sauce", 0.9m }
    };
    private string type;
    private int weight;
    public Topping(string type, int weight)
    {
        Type = type; 
        Weight = weight;
    }
    public string Type
    {
        get => type;
        private set
        {
            string lowerType = value.ToLower();
            if (!ToppingModifiers.ContainsKey(lowerType))
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            type = value; 
        }
    }
    public int Weight
    {
        get => weight;
        private set
        {
            if (value < 1 || value > 50)
                throw new ArgumentException($"{type} weight should be in the range [1..50].");
            weight = value;
        }
    }
    public decimal Calories => 2 * weight * ToppingModifiers[type.ToLower()];
}