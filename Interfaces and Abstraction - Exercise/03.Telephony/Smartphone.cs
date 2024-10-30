using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            if (IsNumberValid(number))
            {
                return $"Calling... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }
        public string Browse(string url)
        {
            if (IsUrlValid(url))
            {
                return $"Browsing: {url}!";
            }
            else
            {
                return "Invalid URL!";
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
            return number.Length == 10;
        }
        private bool IsUrlValid(string url)
        {
            foreach (char c in url)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}