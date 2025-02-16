//Written by Duc Anh Dang
// 02/14/2025
namespace Simula_sTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create enum type
            //assign a current for enum and a current for display
            Chest current = Chest.Locked;
            string current_display = "locked";
            //LOOP FOREVER
            while (true)
            {
                //display current status of chest and get user input and set user input to lowercase
                Console.Write($"The chest is {current_display}. What do you want to do? ");
                string userInput = Console.ReadLine().ToLower();
                //Use condition to make sure that they need do step by step
                //lock - close - open and reverse
                // update current enu type and update string to help display.
                if (current == Chest.Locked && userInput == "unlock")
                {
                    current = Chest.Closed;
                    current_display = "unlocked";
                }
                if(current == Chest.Closed && userInput == "open")
                {
                    current = Chest.Open;
                    current_display = "open";
                }
                if (current == Chest.Open && userInput == "close")
                {
                    current = Chest.Closed;
                    current_display = "unlocked";
                }
                if (current == Chest.Closed && userInput == "lock")
                {
                    current = Chest.Locked;
                    current_display = "locked";
                }
                
            }
        }
        //define enum type
        enum Chest { Open, Closed, Locked }
    }

}
