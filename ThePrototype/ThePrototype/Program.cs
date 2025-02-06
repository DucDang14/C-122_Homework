//Written by Duc Anh Dang
//02/05/2025
namespace ThePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to The Prototype");
            //define
            int num;
            //take user input but it have to in the range 0 to 100
            do
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0 && num > 100);
            //clear console
            Console.Clear();

            Console.WriteLine("User 2, guess the number.");
            //Take user guess and check is that equal with input number til it equal
            while (true)
            {
                Console.Write("What is your next guess? ");
                int GuessNum = Convert.ToInt32(Console.ReadLine());
                if (GuessNum > num) { Console.WriteLine($"{GuessNum} is too high"); }
                else if (GuessNum < num) { Console.WriteLine($"{GuessNum} is too low"); }
                else { Console.WriteLine("You guessed the number"); break; }
            }
            Console.ReadKey();
        }
    }
}
