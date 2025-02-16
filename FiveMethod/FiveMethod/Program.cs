using System.Security.Cryptography.X509Certificates;

namespace FiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Method method = new Method();
            Console.WriteLine("------------------------");
            List<int> MinMax = method.FindMinMax([9, 8, 7, 6, 5, 4, 3, 2, 1]);
            foreach (int i in MinMax)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");

            Console.WriteLine(method.GetAbsSum([2, -1, 4, -8, 10]));
            Console.WriteLine("------------------------");
            int[] arr = method.MultiplyByLength([2,3,1,0]);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine(method.smallerNum("21","44"));
            Console.WriteLine("------------------------");
            Console.WriteLine(method.CountDs("My friend Dylan got distracted in school."));
            Console.ReadLine();
        }
    }
}
