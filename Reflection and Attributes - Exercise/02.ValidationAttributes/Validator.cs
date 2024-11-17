using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                var attributes = property
                    .GetCustomAttributes()
                    .OfType<MyValidationAttribute>();
                foreach (var attribute in attributes)
                {
                    var propertyValue = property.GetValue(obj);
                    if (!attribute.IsValid(propertyValue))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}