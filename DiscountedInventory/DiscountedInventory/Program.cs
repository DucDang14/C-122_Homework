//Written by Duc Anh Dang
//02/05/2025
namespace DiscountedInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Print out the menu
            Console.WriteLine("Welcome to Inventory");
            Console.WriteLine("The following items are avaiable:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.Write("What number do you want to see the price of? ");
            //get number from input
            int check = Convert.ToInt32(Console.ReadLine());
            //assign item with number 
            string item = check switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipment",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies",
                _ => "We do not have your item"
            };
            //assign price with item
            int price = item switch
            {
                "Rope" => 10,
                "Torches" => 15,
                "Climbing Equipment" => 25,
                "Clean Water" => 1,
                "Machete" => 20,
                "Canoe" => 200,
                "Food Supplies" => 1
            };
            //ask user's name and if it correct discount for their items.
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            if (name == "Duc Anh")
            {
                price /= 2;
            }
            Console.WriteLine($"{item} cost {price} gold.");
            Console.ReadKey();
        }
    }
}
