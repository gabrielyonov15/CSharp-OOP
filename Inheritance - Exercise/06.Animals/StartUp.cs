namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();
            string input;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                string type = input;
                string[] animalDetails = Console.ReadLine().Split();
                string name = animalDetails[0];
                int age;
                if (animalDetails.Length < 2 || !int.TryParse(animalDetails[1], out age))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string gender = animalDetails.Length > 2 ? animalDetails[2] : null;
                try
                {
                    switch (type)
                    {
                        case "Dog":
                            animals.Add(new Dog(name, age, gender));
                            break;
                        case "Frog":
                            animals.Add(new Frog(name, age, gender));
                            break;
                        case "Cat":
                            animals.Add(new Cat(name, age, gender));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(name, age));
                            break;
                        case "Tomcat":
                            animals.Add(new Tomcat(name, age));
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}