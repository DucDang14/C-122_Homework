namespace SortArrayByParity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Solution solution = new Solution();
            int[] nums = [3, 1, 2, 4];
            int[] arr = solution.SortArrayByParity(nums);
            foreach (int i in arr)
            {
                Console.Write(i+"\t");
            }

            Console.ReadKey();
        }
    }
}
