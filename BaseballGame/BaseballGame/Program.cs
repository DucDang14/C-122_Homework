//Written by Duc Anh Dang
//04/16/2025
namespace BaseballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] ops = ["5", "-2", "4", "C", "D", "9", "+", "+"];
            Console.WriteLine(solution.CalPoints(ops));
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}
