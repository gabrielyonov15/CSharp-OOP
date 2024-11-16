using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, string[] fieldsToInvestigate)
        {
            Type type = Type.GetType(className);
            if (type == null)
                throw new ArgumentException($"Class {className} not found");
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Class under investigation: {className}");
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            object classInstance = Activator.CreateInstance(type);
            foreach (FieldInfo field in fields)
            {
                if (Array.Exists(fieldsToInvestigate, f => f == field.Name))
                {
                    result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
                }
            }
            return result.ToString();
        }
    }
}