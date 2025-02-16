//Written by Duc Anh Dang
// 02/14/2025
using System.Drawing;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace BossBattleHuntingTheManticore
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Define basic stuff 
            int station;
            int city = 15;
            int manticore = 10;
            int round = 1;
            int hit;
            //Create an object
            Hunting hunting = new Hunting();
            //Take the number from user input
            station = hunting.PickScoreP1("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);

            //Clear console
            Console.Clear();

            Console.WriteLine("Player 2, it is your turn.");
            //using while loop to run until the city or manticore come to 0
            while (city > 0 && manticore > 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("----------------------------------------------");
                //display
                hunting.Status(round,city, manticore);
                //calc damage depend on round
                int damage = hunting.DamageHit(round);
                Console.ForegroundColor= ConsoleColor.Blue;
                //display damage
                Console.WriteLine($"The canon is expected to deal {damage} damage this round.");
                //Take a guess from user input
                int guessRange = hunting.PickScore("Enter desiredcannon range: ");
                //check is that direct or over or under the spot
                hunting.OverOrUnder(station, guessRange);
                //update damage if direct, and update number of city health and round
                if (guessRange == station)
                {
                    manticore -= damage;
                }
                if (manticore > 0)
                {
                    city--;
                }
                round++;
                
            }
            //check win or lose
            bool won = city > 0;
            hunting.WinOrLose(won);
            Console.ReadKey();

        }
    }
}

