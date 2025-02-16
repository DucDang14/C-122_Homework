//Written by Duc Anh Dang
//02/14/2025
using System.Dynamic;
using VinFletcher_sArrows;

namespace Vin_sTrouble
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            //create new arrow object
            Arrow arrow = Arrow.GetArrow();
            //Ask about materials and display cost
            Console.WriteLine($"Your arrow cost {arrow.GetCost} gold.");
            Console.ReadKey();
        }
    }
}
