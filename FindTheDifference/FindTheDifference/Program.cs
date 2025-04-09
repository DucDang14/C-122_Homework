//Written by Duc Anh Dang
//04/07/2025
namespace FindTheDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "abcd";
            string t = "abcde";
            Console.WriteLine(solution.FindTheDifference(s,t));
            
            Console.ReadKey();
        }
    }
}
