//Written by Duc Anh Dang
//02/05/2025
namespace TheReplicatorOfDTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Replicator of D'To");
            //create first array
            int[] array = new int[5];
            //take 5 number from user and put it into array
            for (int i = 0; i < array.Length; i++)
            { 
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //create a second array
            int[] array2 = new int[5];
            //copy the value from array 1 to array 2
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            //printout 2 array
            foreach (int i in array) { Console.Write(i); }
            foreach (int i in array2) { Console.Write(i); }

            Console.ReadKey();
        }
    }
}
