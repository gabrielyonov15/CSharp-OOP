namespace _04.WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] animalData = input.Split();
                string type = animalData[0];
                Animal animal = type switch
                {
                    "Owl" => new Owl(animalData[1], double.Parse(animalData[2]), double.Parse(animalData[3])),
                    "Hen" => new Hen(animalData[1], double.Parse(animalData[2]), double.Parse(animalData[3])),
                    "Mouse" => new Mouse(animalData[1], double.Parse(animalData[2]), animalData[3]),
                    "Dog" => new Dog(animalData[1], double.Parse(animalData[2]), animalData[3]),
                    "Cat" => new Cat(animalData[1], double.Parse(animalData[2]), animalData[3], animalData[4]),
                    "Tiger" => new Tiger(animalData[1], double.Parse(animalData[2]), animalData[3], animalData[4]),
                    _ => null
                };
                if (animal != null)
                {
                    animals.Add(animal);
                    animal.MakeSound();
                    string[] foodData = Console.ReadLine().Split();
                    string foodType = foodData[0];
                    int quantity = int.Parse(foodData[1]);
                    Food food = foodType switch
                    {
                        "Vegetable" => new Vegetable(quantity),
                        "Fruit" => new Fruit(quantity),
                        "Meat" => new Meat(quantity),
                        "Seeds" => new Seeds(quantity),
                        _ => null
                    };
                    animal.Eat(food);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}