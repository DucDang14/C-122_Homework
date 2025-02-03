//Written by Duc Anh Dang
//01/02/25
namespace TheDominionOfKings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dominion of Kings");
            //define and let user input
            int provinces, duckies, estates, total;
            Console.WriteLine("How many provinces do you have?");
            provinces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many duckies do you have?");
            duckies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many estates do you have?");
            estates = Convert.ToInt32(Console.ReadLine());

            //Calculate
            total = (1 * estates) + (3 * duckies) + (6 * provinces);

            //Display the point total to the user
            Console.WriteLine("The point total is: " + total);

            Console.ReadKey();
        }
    }
}
