//Written by Duc Anh Dang
//02/25/2025
namespace ShapesAndAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object for each class except class shape because it's abstract class and printing out
            Console.WriteLine("Hello, World!");
            Rectangle rectangle = new Rectangle("Red", 5,6);
            Console.WriteLine(rectangle.ToString());
            Circle circle = new Circle("Green", 8);
            Console.WriteLine(circle.ToString());
            Console.ReadKey();
        }
    }
}
