//Written by Duc Anh Dang
// 02/14/2025
namespace Simula_sSoup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object
            Soup Soup = new Soup();
            //take tuples return from soup class and assign to soup tuple
            (SoupType type, MainIngredient ingredient, Seasoning seasoning) soup = Soup.GetSoup();
            //Display stuff 
            Console.WriteLine($"Your order is {soup.seasoning} {soup.ingredient} {soup.type}");
            Console.ReadKey();
        }
        
    }
    //create enum type
    enum SoupType { Soup, Stew, Gumbo };
    enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
    enum Seasoning { Spicy, Salty, Sweet }
}
