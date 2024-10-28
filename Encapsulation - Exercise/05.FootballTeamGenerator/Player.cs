using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A name should not be empty.");
                name = value;
            }
        }
        public int Endurance
        {
            get => endurance;
            private set
            {
                ValidateStat(value, "Endurance");
                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            private set
            {
                ValidateStat(value, "Sprint");
                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;
            private set
            {
                ValidateStat(value, "Dribble");
                dribble = value;
            }
        }
        public int Passing
        {
            get => passing;
            private set
            {
                ValidateStat(value, "Passing");
                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting;
            private set
            {
                ValidateStat(value, "Shooting");
                shooting = value;
            }
        }
        public double SkillLevel => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
        private void ValidateStat(int value, string statName)
        {
            if (value < 0 || value > 100)
                throw new ArgumentException($"{statName} should be between 0 and 100.");
        }
    }
}