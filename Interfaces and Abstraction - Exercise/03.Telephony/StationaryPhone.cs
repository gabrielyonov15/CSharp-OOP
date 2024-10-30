using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (IsNumberValid(number))
            {
                return $"Dialing... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }
        private bool IsNumberValid(string number)
        {
            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return number.Length == 7;
        }
    }
}