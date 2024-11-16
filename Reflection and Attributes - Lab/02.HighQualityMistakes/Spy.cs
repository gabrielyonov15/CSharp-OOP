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
        public string AnalyzeAccessModifiers(string className)
        {
            Type type = Type.GetType(className);
            if (type == null)
                throw new ArgumentException($"Class {className} not found");
            StringBuilder result = new StringBuilder();
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            foreach (FieldInfo field in fields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (MethodInfo method in methods)
            {
                if (method.Name.StartsWith("get_") && !method.IsPublic)
                {
                    result.AppendLine($"{method.Name} have to be public!");
                }
                else 
                if (method.Name.StartsWith("set_") && !method.IsPrivate)
                {
                    result.AppendLine($"{method.Name} have to be private!");
                }
            }
            return result.ToString();
        }
    }
}