//Written by Duc Anh Dang
//02/14/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletcher_sArrows
{
    public class Arrow
    {
        //define private variables

        public ArrowheadType ArrowheadType
        {
            get;
        }
        public FletchingType FletchingType
        {
            get; 
        }
        public float Length
        {
            get;
        }

        //Get arrow head type
        public static ArrowheadType GetArrowHead()
        {
            Console.Write("What do you want (steel, wood, obsidian)? ");
            string type = Console.ReadLine();
            return type switch
            {
                "steel" => ArrowheadType.Steel,
                "wood" => ArrowheadType.Wood,
                "obsidian" => ArrowheadType.Obsidian,
            };
        }
        //Constructor
        public Arrow(ArrowheadType arrowhead, FletchingType fletching, float length)
        {
            ArrowheadType = arrowhead;
            FletchingType = fletching;
            Length = length;
        }

        public static Arrow GetArrow()
        {
            ArrowheadType arrowhead = GetArrowHead();
            FletchingType fletching = GetFletching();
            float length = GetLength();

            return new Arrow(arrowhead, fletching, length);
        }

        //Get fletching type
        public static FletchingType GetFletching()
        {
            Console.Write("What do you want (plastic, turkey feathers, goose feathers)? ");
            string type = Console.ReadLine();
            return type switch
            {
                "plastic" => FletchingType.Plastic,
                "turkey feathers" => FletchingType.TurkeyFeathers,
                "goose feathers" => FletchingType.GooseFeathers,
            };
        }
        //Get length
        public static float GetLength()
        {
            float length = 0;
            while (length < 60 || length > 100)
            {
                Console.Write("Arrow length (between 60 and 100): ");
                length = Convert.ToSingle(Console.ReadLine());
            }
            return length;
        }
        //Call 3 methods above to let user put what material they want and assign with the materials cost
        //After that return the arrow cost
        public float GetCost
        {
            get
            {
                float arrowHeadCost = ArrowheadType switch
                {
                    ArrowheadType.Steel => 10,
                    ArrowheadType.Wood => 3,
                    ArrowheadType.Obsidian => 5,
                };
                float fletchingCost = FletchingType switch
                {
                    FletchingType.Plastic => 10,
                    FletchingType.GooseFeathers => 5,
                    FletchingType.TurkeyFeathers => 3,
                };
                float shaftCost = 0.05f * Length;
                return arrowHeadCost + fletchingCost + shaftCost;
            }  
        }
    }
    //Create 2 enum types
    public enum ArrowheadType { Steel, Wood, Obsidian };
    public enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers };
}
