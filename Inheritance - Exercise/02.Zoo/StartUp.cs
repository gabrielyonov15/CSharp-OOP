namespace Zoo
{
    public class StartUp
    {
        static void Main()
        {
            Zoo.Lizard lizard = new Zoo.Lizard("Green Lizard");
            Zoo.Snake snake = new Zoo.Snake("Python");
            Zoo.Gorilla gorilla = new Zoo.Gorilla("King Kong");
            Zoo.Bear bear = new Zoo.Bear("Grizzly");

            Console.WriteLine(lizard.Name);
            Console.WriteLine(snake.Name);
            Console.WriteLine(gorilla.Name);
            Console.WriteLine(bear.Name);
        }
    }
}