namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            int val = 2;
            Solution solution = new Solution();
            Console.WriteLine(solution.RemoveElement(nums, val));

            Console.ReadLine();
        }
    }
}
