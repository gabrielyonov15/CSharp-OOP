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
        public string RevealPrivateMethods(string className)
        {
            Type type = Type.GetType(className);
            if (type == null)
                throw new ArgumentException($"Class {className} not found");
            StringBuilder result = new StringBuilder();
            result.AppendLine($"All Private Methods of Class: {className}");
            result.AppendLine($"Base Class: {type.BaseType.Name}");
            MethodInfo[] privateMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (MethodInfo method in privateMethods)
            {
                result.AppendLine(method.Name);
            }
            return result.ToString();
        }
    }
}