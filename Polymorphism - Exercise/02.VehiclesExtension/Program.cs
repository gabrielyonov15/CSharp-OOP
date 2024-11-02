namespace _02.VehiclesExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
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
                    else 
                    if (vehicleType == "Bus")
                    {
                        bus.DriveWithPeople(value);
                    }
                }
                else
                if (action == "DriveEmpty" && vehicleType == "Bus")
                {
                    bus.Drive(value);
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
                    else 
                    if (vehicleType == "Bus")
                    {
                        bus.Refuel(value);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}