//Written by Duc Anh Dang
//02/14/2025
namespace VinFletcher_sArrows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //create new arrow object
            Arrow arrow = new Arrow();
            //Ask about materials and display cost
            Console.WriteLine($"Your arrow cost {arrow.GetCost()} gold.");
            Console.ReadKey();
        }
    }
}
