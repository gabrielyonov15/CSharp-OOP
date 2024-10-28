using System.Numerics;

namespace _05.FootballTeamGenerator
{
    public class Program
    {
        private static Dictionary<string, Team> teams = new();
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(';');
                try
                {
                    switch (tokens[0])
                    {
                        case "Team":
                            CreateTeam(tokens[1]);
                            break;
                        case "Add":
                            AddPlayerToTeam(tokens);
                            break;
                        case "Remove":
                            RemovePlayerFromTeam(tokens);
                            break;
                        case "Rating":
                            PrintTeamRating(tokens[1]);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static void CreateTeam(string teamName)
        {
            var team = new Team(teamName);
            teams[teamName] = team;
        }
        private static void AddPlayerToTeam(string[] tokens)
        {
            string teamName = tokens[1];
            string playerName = tokens[2];
            int endurance = int.Parse(tokens[3]);
            int sprint = int.Parse(tokens[4]);
            int dribble = int.Parse(tokens[5]);
            int passing = int.Parse(tokens[6]);
            int shooting = int.Parse(tokens[7]);
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }
            var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
            teams[teamName].AddPlayer(player);
        }
        private static void RemovePlayerFromTeam(string[] tokens)
        {
            string teamName = tokens[1];
            string playerName = tokens[2];
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }
            teams[teamName].RemovePlayer(playerName);
        }
        private static void PrintTeamRating(string teamName)
        {
            if (!teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
            else
            {
                Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
            }
        }
    }
}