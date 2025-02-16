//Written by Duc Anh Dang
//02/14/2025
using System.Threading.Channels;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Methods methods = new Methods();
            //words count
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Word Count");
            Console.WriteLine(methods.countWords("Just an example here move along"));
            Console.WriteLine(methods.countWords("This is a test"));
            Console.WriteLine(methods.countWords("What an easy task, right"));
            //Flip end Char
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Flip end Char");
            Console.WriteLine(methods.flipEndChars("Cat, dog, and mouse."));
            Console.WriteLine(methods.flipEndChars("ada"));
            Console.WriteLine(methods.flipEndChars("Ada"));
            Console.WriteLine(methods.flipEndChars("z"));
            ////Is in order 
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Is in order ?");
            Console.WriteLine(methods.isInOrder("abc"));
            Console.WriteLine(methods.isInOrder("edabit"));
            Console.WriteLine(methods.isInOrder("123"));
            Console.WriteLine(methods.isInOrder("xyzz"));
            //First n vowels of a string
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(methods.firstNVowels("sharpening skills", 3));
            Console.WriteLine(methods.firstNVowels("major league", 5));
            Console.WriteLine(methods.firstNVowels("hoste", 5));
            ////Change letter to next letter
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(methods.move("hello"));
            Console.WriteLine(methods.move("bye"));
            Console.WriteLine(methods.move("welcome"));
            
            Console.ReadKey();
        }
    }
}
