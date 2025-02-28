//Written by Duc Anh Dang
//02/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    //create base class
    public class Animal
    {
        //define variable
        private string name = "n/a";
        //getset
        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }
        //constructor
        public Animal(string aName)
        {
            Name = aName;
        }
        //virtual method
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }
        //ToString method
        public override string ToString()
        {
            return $"Animal: { Name }, Sound: {MakeSound()}";
        }
    }
    //subclass
    public class Dog : Animal 
    {
        //constructor
        public Dog(string aName) : base(aName) { }
        //change virtual method
        public override string MakeSound()
        {
            return "Bark";
        }
        //ToString method
        public override string ToString()
        {
            return $"Dog: {Name}, Sound: {MakeSound()}";
        }
    }
    //sub class
    public class Cat : Animal
    {
        //constructor
        public Cat(string aName) : base(aName) { }
        //change virtual method
        public override string MakeSound()
        {
            return "Meow";
        }
        //ToString method
        public override string ToString()
        {
            return $"Cat: {Name}, Sound: {MakeSound()}";
        }
    }
}
