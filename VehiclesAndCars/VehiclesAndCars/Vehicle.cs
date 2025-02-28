//Written by Duc Anh Dang
//02/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    //base class vehicle
    public class Vehicle
    {
        //properties
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;
        //get & set
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //Constructor 
        public Vehicle(string aMake, string aModel, int aYear)
        {
            Make = aMake;
            Model = aModel;
            Year = aYear;
        }
        public Vehicle() : this("n/a","n/a",-1) { }

        //ToString method
        public override string ToString()
        {
            return "Make: " + Make + "\n" + "Model: " + Model + "\n" + "Year: " + Year; 
        }
    }
    //sub class car
    public class Car : Vehicle
    {
        //define variable
        private int numberOfDoor = 4;
        //get set
        public int NumberOfDoor
        {
            get { return numberOfDoor; }
            set { numberOfDoor = value; }
        }
        //constructor
        public Car(string aMake, string aModel, int aYear, int aNumberOfDoor)
        {
            Make = aMake;
            Model = aModel;
            Year = aYear;
            NumberOfDoor = aNumberOfDoor;
        }
        public Car() : base("n/a", "n/a", -1) { }
        //ToString method
        public override string ToString()
        {
            return $"{base.Year} {base.Make} {base.Model} with {this.NumberOfDoor} Number of Doors"; 
        }
    }
    //sub class motorcycle
    public class Motorcycle : Vehicle
    {
        //define
        private bool hasSideCar = false;
        //get set
        public bool HasSideCar
        {
            get { return hasSideCar; }
            set { hasSideCar = value; }
        }
        //constructor
        public Motorcycle(string aMake, string aModel, int aYear, bool HasSideCar)
        {
            Make = aMake;
            Model = aModel;
            Year = aYear;
            this.HasSideCar = HasSideCar;
        }
        public Motorcycle() : base("n/a", "n/a", -1) { }
        //ToString method
        public override string ToString()
        {
            return $"{base.Year} {base.Make} {base.Model} (Has Sidecar: {this.hasSideCar})";
        }
    }

}
