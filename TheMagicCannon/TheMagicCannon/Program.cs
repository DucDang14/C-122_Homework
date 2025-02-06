//Written by Duc Anh Dang
//02/05/2025
using System.Runtime.InteropServices;

namespace TheMagicCannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Magic Cannon");
            //Loop through 1 to 100
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {   //change the text color
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    //print out
                    Console.WriteLine($"{i}: Electric and Fire");
                }
                else if (i % 5 == 0)
                {
                    //change the text color
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    //print out
                    Console.WriteLine($"{i}: Electric");
                }
                else if (i % 3 == 0)
                {
                    //change the text color
                    Console.ForegroundColor = ConsoleColor.Red;
                    //print out
                    Console.WriteLine($"{i}: Fire");
                }
                else 
                {
                    //change the text color
                    Console.ForegroundColor = ConsoleColor.White;
                    //print out
                    Console.WriteLine($"{i}: Normal");
                }
                Console.ReadLine();
            }
        }
    }
}
