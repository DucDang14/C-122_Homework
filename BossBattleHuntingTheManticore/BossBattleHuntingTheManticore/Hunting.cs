//Written by Duc Anh Dang
// 02/14/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBattleHuntingTheManticore
{
    internal class Hunting
    {
        //Method

        //Check win or lose
        public void WinOrLose(bool won)
        {
            if (won)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The city has been destroyed!");
            }
        }
        //Check the guess number 
        public void OverOrUnder(int range, int target)
        {
            if (target < range)
            {
                Console.WriteLine("That round FELL SHORT of the target");
            }
            else if (target > range)
            {
                Console.WriteLine("That round OVERSHOT the target");
            }
            else
            {
                Console.WriteLine("That round was a DIRECT HIT!");
            }
        }
        //display the status
        public void Status(int round, int city, int manticore)
        {
            Console.WriteLine($"STATUS: Round: {round} City: {city}/15 Manticore: {manticore}/10");
        }
        //calc the damage base on round
        public int DamageHit(int round)
        {
            if (round % 3 == 0 && round % 5 == 0)
            {
                return 10;
            }
            else if (round % 3 == 0 || round % 5 == 0)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
        //Check is user input from 0 - 100
        public int PickScoreP1(string msg, int min, int max)
        {
            while (true)
            {
                int number = PickScore(msg);
                if (number >= min && number <= max)
                {
                    return number;
                }
            }

        }
        //take user input for p1 and p2 
        public int PickScore(string msg)
        {
            Console.WriteLine(msg + "");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}
