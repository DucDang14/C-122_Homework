namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [ 2, 7, 11, 15 ];
            int target = 9;
            Solution solution = new Solution();
            int[] newArr = solution.TwoSum(arr, target);
            foreach (int i in newArr)
            {
            Console.Write(i + "\t");
            }
            Console.ReadKey();
        }
    }
}
