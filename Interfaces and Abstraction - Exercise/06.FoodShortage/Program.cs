namespace _06.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var buyers = new Dictionary<string, IBuyer>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                if (tokens.Length == 4) 
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    string birthdate = tokens[3];
                    buyers[name] = new Citizen(name, age, id, birthdate);
                }
                else 
                if (tokens.Length == 3) 
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string group = tokens[2];
                    buyers[name] = new Rebel(name, age, group);
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (buyers.ContainsKey(command))
                {
                    buyers[command].BuyFood();
                }
            }
            int totalFood = 0;
            foreach (var buyer in buyers.Values)
            {
                totalFood += buyer.Food;
            }
            Console.WriteLine(totalFood);
        }
    }
}