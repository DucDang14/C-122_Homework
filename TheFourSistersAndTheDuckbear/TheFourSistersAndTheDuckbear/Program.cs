//Written by Duc Anh Dang
//01/02/25
namespace TheFourSistersAndTheDuckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Four Sisters and the Duckbear");
            //define
            int numberOfChocolateEggs;
            int eggPerSis = -1;
            int remainder = 0;
            bool check = true;
            //take user input
            do
            {
                Console.WriteLine("Please enter number greater or equal 4");
                Console.Write("Enter the number of chocollate eggs: ");
                numberOfChocolateEggs = Convert.ToInt32(Console.ReadLine());
            } while (numberOfChocolateEggs < 4);
            //cal chocolate eggs for 4 sisters and left for duckbear
            while (check)
            {
                if (numberOfChocolateEggs % 4 == 0)
                {
                    eggPerSis = numberOfChocolateEggs / 4;
                    check = false;
                }
                else
                {
                    numberOfChocolateEggs--;
                    remainder++;
                }
            }
            //Printing out
            Console.WriteLine($"The chocolate eggs each sister should get is: {eggPerSis}, left over for the duckbear: {remainder}");

            Console.ReadKey();
        }
    }
}
