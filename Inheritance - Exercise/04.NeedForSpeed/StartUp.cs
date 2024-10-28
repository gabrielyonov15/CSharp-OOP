namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main()
        {
            Vehicle car = new Car(120, 50);
            car.Drive(10);
            Console.WriteLine(car.Fuel);
        }
    }
}