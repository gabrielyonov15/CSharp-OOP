namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0];
                string vehicleType = command[1];
                double value = double.Parse(command[2]);
                if (action == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(value);
                    }
                    else 
                    if (vehicleType == "Truck")
                    {
                        truck.Drive(value);
                    }
                }
                else 
                if (action == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(value);
                    }
                    else 
                    if (vehicleType == "Truck")
                    {
                        truck.Refuel(value);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}