public class Pizza
{
    private string name;
    private readonly List<Topping> toppings;
    public Pizza(string name)
    {
        Name = name;
        toppings = new List<Topping>();
    }
    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            name = value;
        }
    }
    public Dough Dough { get; set; }
    public int ToppingCount => toppings.Count;
    public void AddTopping(Topping topping)
    {
        if (toppings.Count >= 10)
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        toppings.Add(topping);
    }
    public decimal TotalCalories
    {
        get
        {
            decimal totalCalories = Dough?.Calories ?? 0;
            totalCalories += toppings.Sum(t => t.Calories);
            return totalCalories;
        }
    }
}