namespace MergeSortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;
            //create object
            Solution solution = new Solution();
            //create list and assign with return list
            int[] list = solution.Merge(nums1,m,nums2,n);
            //Print out
            foreach (int i in list)
            {
                Console.Write(i+ "\t");
            }
            Console.ReadKey();
        }
    }
}
