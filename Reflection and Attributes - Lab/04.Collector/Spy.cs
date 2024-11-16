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
        public string CollectGettersAndSetters(string className)
        {
            Type type = Type.GetType(className);
            if (type == null)
                throw new ArgumentException($"Class {className} not found");
            StringBuilder result = new StringBuilder();
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (MethodInfo method in methods)
            {
                if (method.Name.StartsWith("get_"))
                {
                    result.AppendLine($"{method.Name} will return {method.ReturnType}");
                }
                else 
                if (method.Name.StartsWith("set_"))
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    if (parameters.Length == 1) 
                    {
                        result.AppendLine($"{method.Name} will set field of {parameters[0].ParameterType}");
                    }
                }
            }
            return result.ToString();
        }
    }
}