using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();
        public string RandomString()
        {
            if (this.Count == 0)
            {
                return string.Empty;
            }
            int index = random.Next(0, this.Count);
            string randomElement = this[index];
            this.RemoveAt(index);
            return randomElement;
        }
    }
}