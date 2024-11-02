using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; private set; }
        public int Power { get; protected set; }
        protected BaseHero(string name)
        {
            Name = name;
        }
        public abstract string CastAbility();
    }
}