//Written by Duc Anh Dang
//04/07/2025
namespace MergeStringsAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Solution solution = new Solution();
            string word1 = "abc", word2 = "pqr";
            Console.WriteLine(solution.MergeAlternately(word1,word2));
            Console.ReadKey();
        }
    }
}
