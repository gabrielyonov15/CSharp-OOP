using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Raiding
{
    public class HeroFactory
    {
        public static BaseHero CreateHero(string name, string type)
        {
            return type switch
            {
                "Druid" => new Druid(name),
                "Paladin" => new Paladin(name),
                "Rogue" => new Rogue(name),
                "Warrior" => new Warrior(name),
                _ => null
            };
        }
    }
}