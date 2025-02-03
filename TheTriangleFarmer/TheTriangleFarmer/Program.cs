//Written by Duc Anh Dang
//01/02/25
namespace TheTriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Triangle Farmer");
            //input Base and Height
            Console.Write("Base: ");
            double triBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double triHeight = Convert.ToDouble(Console.ReadLine());
            //Calculate
            double areaOfTriangle = (triBase * triHeight)/2.0;
            //Print out
            Console.WriteLine("The area of triangle is: " + areaOfTriangle);
            Console.ReadKey();
        }
    }
}
