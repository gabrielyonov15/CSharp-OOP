using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{this.GetType().Name} -> ");
            stringBuilder.Append($"Name: {this.Name}, Age: {this.Age}");
            return stringBuilder.ToString();
        }
    }
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            if (age > 15)
            {
                throw new ArgumentException("Child's age must be 15 or less!");
            }
        }
    }
}