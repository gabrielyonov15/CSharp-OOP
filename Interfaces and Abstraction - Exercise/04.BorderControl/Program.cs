namespace _04.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> entrants = new List<IIdentifiable>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    entrants.Add(new Citizen(name, age, id));
                }
                else
                if (tokens.Length == 2)
                {
                    string model = tokens[0];
                    string id = tokens[1];
                    entrants.Add(new Robot(model, id));
                }
            }
            string fakeIdEnding = Console.ReadLine();
            foreach (var entrant in entrants)
            {
                if (entrant.Id.EndsWith(fakeIdEnding))
                {
                    Console.WriteLine(entrant.Id);
                }
            }
        }
    }
}