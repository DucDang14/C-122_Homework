using System.Runtime.InteropServices;

namespace FindtheIndexOfTheFirstOccurrenceInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int s = solution.Check(haystack: "sadbutsad", needle: "sad");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
