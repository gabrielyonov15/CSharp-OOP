using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }
        protected Animal(string name, int age, string gender)
        {
            if (string.IsNullOrWhiteSpace(name) || age < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            Name = name;
            Age = age;
            Gender = gender;
        }
        public abstract string ProduceSound();
    }
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender) { }
        public override string ProduceSound() => "Woof!";
    }
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender) { }
        public override string ProduceSound() => "Ribbit";
    }
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender) { }
        public override string ProduceSound() => "Meow meow";
    }
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, "Female") { }
        public override string ProduceSound() => "Meow";
    }
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, "Male") { }
        public override string ProduceSound() => "MEOW";
    }
}