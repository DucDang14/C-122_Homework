//Written by Duc Anh Dang
//04/07/2025
namespace NumberOfSegmentsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Solution solution = new Solution();
            string s = "                ";
            int count;
            Console.WriteLine(solution.CountSegments(s));
            
            Console.ReadKey();
        }
    }
}
