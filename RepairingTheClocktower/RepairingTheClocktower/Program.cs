//Written by Duc Anh Dang
//01/02/25
namespace RepairingTheClocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clockNumber;
            Console.WriteLine("Enter a number: ");
            clockNumber = Convert.ToInt32(Console.ReadLine());
            if (clockNumber % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
            Console.ReadKey();

        }
    }
}
