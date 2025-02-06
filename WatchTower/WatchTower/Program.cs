//Written by Duc Anh Dang
//02/05/2025
using System.Xml.Schema;

namespace WatchTower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Watch Tower");
            //Define value & get input from user
            Console.Write("Enter x value: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y value: ");
            int y = Convert.ToInt32(Console.ReadLine());
            //check condition and print out
            if (x < 0)
            {
                if (y < 0) { Console.WriteLine("The enemy is to the southwest!");}
                else if (y > 0) { Console.WriteLine("The enemy is to the northwest!"); }
                else { Console.WriteLine("The enemy is to the west!"); }
            }
            else if (x > 0)
            {
                if (y < 0) { Console.WriteLine("The enemy is to the southest!"); }
                else if (y > 0) { Console.WriteLine("The enemy is to the east!"); }
                else { Console.WriteLine("The enemy is to the northeast!"); }
            }
            else 
            {
                if (y < 0) { Console.WriteLine("The enemy is to the south!"); }
                else if (y > 0) { Console.WriteLine("The enemy is to the north!"); }
                else { Console.WriteLine("The enemy is here !"); }
            }


            Console.ReadKey();
        }
    }
}
