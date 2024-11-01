using System.Drawing;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(5, 10);
            Shape circle = new Circle(7);
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Rectangle Perimeter: {rectangle.CalculatePerimeter()}");
            Console.WriteLine(circle.Draw());
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");
        }
    }
}