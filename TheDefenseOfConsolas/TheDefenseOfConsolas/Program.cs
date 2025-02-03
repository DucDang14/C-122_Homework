//Written by Duc Anh Dang
//01/02/25
namespace TheDefenseOfConsolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            do
            {
                Console.WriteLine("Enter number greater than 0 and less than 9");
                Console.Write("Target Row? ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Target Column? ");
                column = Convert.ToInt32(Console.ReadLine());
            }while (row < 1 && column < 1 || row > 8 && column > 8);
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"({row},{column-1})");
            Console.WriteLine($"({row-1},{column})");
            Console.WriteLine($"({row},{column+1})");
            Console.WriteLine($"({row+1},{column})");

            Console.Beep();
            Console.ReadKey();
        }
    }
}
