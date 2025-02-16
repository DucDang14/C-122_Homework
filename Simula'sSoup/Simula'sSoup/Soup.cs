//Written by Duc Anh Dang
// 02/14/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simula_sSoup
{
    internal class Soup
    {
        //create a tuples get everything for the soup
        public (SoupType , MainIngredient , Seasoning) GetSoup()
        {
            SoupType type = GetSoupType();
            MainIngredient ingredient = GetMainIngredient();
            Seasoning seasoning = GetSeasoning();
            return (type, ingredient, seasoning);
        }
        //create get a soup type take input from user
        public SoupType GetSoupType()
        {
            Console.Write("Soup type (soup, stew, gumbo): ");
            string input = Console.ReadLine(); ;
            return input switch
            {
                "soup" => SoupType.Soup,
                "stew" => SoupType.Stew,
                "gumbo" => SoupType.Gumbo,
            };
        }
        //create main ingreadient and get from user 
        public MainIngredient GetMainIngredient()
        {
            Console.Write(" Main ingredient (Mushrooms, Chicken, Carrots, Potatoes): ");
            string input = Console.ReadLine(); ;
            return input switch
            {
                "mushrooms" => MainIngredient.Mushrooms,
                "chicken" => MainIngredient.Chicken,
                "carrots" => MainIngredient.Carrots,
                "potatoes" => MainIngredient.Potatoes,
            };
        }
        //create seasoning and get from user
        public Seasoning GetSeasoning()
        {
            Console.Write("Seasoning (spicy, salty, sweet): ");
            string input = Console.ReadLine(); ;
            return input switch
            {
                "spicy" => Seasoning.Spicy,
                "salty" => Seasoning.Salty,
                "sweet" => Seasoning.Sweet,
            };
        }
    }

}
