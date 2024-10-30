namespace _05.BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            var entitiesWithBirthdates = new List<IBirthdate>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                { 
                    break;
                }
                string[] tokens = input.Split(' ');
                string type = tokens[0];
                if (type == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthdate = tokens[4];
                    entitiesWithBirthdates.Add(new Citizen(name, age, id, birthdate));
                }
                else 
                if (type == "Pet")
                {
                    string name = tokens[1];
                    string birthdate = tokens[2];
                    entitiesWithBirthdates.Add(new Pet(name, birthdate));
                }
            }
            int specificYear = int.Parse(Console.ReadLine());
            foreach (var entity in entitiesWithBirthdates)
            {
                string[] dateParts = entity.Birthdate.Split('/');
                int year = int.Parse(dateParts[2]);
                if (year == specificYear)
                {
                    Console.WriteLine(entity.Birthdate);
                }
            }
        }
    }
}