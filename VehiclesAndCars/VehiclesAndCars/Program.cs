//Written by Duc Anh Dang
//02/25/2025
namespace VehiclesAndCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create 3 object for each 3 class
            Console.WriteLine("Hello, World!");
            //class vehicle
            Vehicle vehicle = new Vehicle("toyota","cross", 2024);
            //class car
            Car car = new Car("lexus", "rx350", 2025,4);
            //class motorbike
            Motorcycle motorcycle = new Motorcycle();
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine(car.ToString());
            Console.WriteLine(motorcycle.ToString());
            Console.ReadKey();
        }
    }
}
