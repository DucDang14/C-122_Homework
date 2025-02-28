using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    //base abstract class Shape
    public abstract class Shape
    {
        //define variable
        private static string color = "n/a";
        //getset
        public static string Color
        {
            get { return color; }
            set { color = value; }
        }
        //constructor
        public Shape(string color)
        {
            Color = color;
        }
        //abstract method
        public abstract double GetArea();
        //overriding tostring
        public override string ToString()
        {
            return "Color shape: " + Color;
        }
    }
    //Sub class
    public class Rectangle : Shape
    {
        //define variable for rectangle
        private int height = -1;
        private int width = -1;
        //getset
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        //constructor
        public Rectangle() : base("n/a") { }
        public Rectangle(string aColor, int aHeight, int aWidth) : base(aColor) 
        {
            Color = aColor;
            Height = aHeight;
            Width = aWidth;
        }
        //overriding
        public override double GetArea()
        {
            return Height * Width;
        }
        //Tostring method
        public override string ToString()
        {
            return "Color shape: " + Color + "Area: " + GetArea();
        }
    }

    //sub class circle
    public class Circle : Shape
    {
        //define variable for circle
        private int radius = -1;
        //getset
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        //constructor
        public Circle() : base("n/a") { } 
        public Circle(string aColor, int aRadius) : base(aColor)
        {
            Color = aColor;
            Radius = aRadius;
        }
        //overriding 
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        //ToString method
        public override string ToString()
        {
            return "Color shape: " + Color + "Area: " + GetArea();
        }
    }

}
