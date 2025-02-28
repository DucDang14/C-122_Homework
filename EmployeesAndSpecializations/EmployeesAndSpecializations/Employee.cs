//Written by Duc Anh Dang
//02/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    //base class
    public class Employee
    {
        //define variable
        private string name = "n/a";
        private int salary = -1;
        //get&set
        public string Name
        {
            get { return name; }
            set { name = value ; } 
        }
        public int Salary
        { 
            get { return salary; }
            set { salary = value ; }
        }
        //constructor
        public Employee(string aName, int aSalary)
        {
            Name = aName ;
            Salary = aSalary ;
        }
        public Employee() : this("n/a", -1) { }
        //ToString method
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: {Salary}"; 
        }
    }
    //subclass
    public class Manager : Employee
    {
        //define new variable only in manager
        private int numberOfemployeesManaged = 0;
        //getset
        public int NumberOfemployeesManaged
        {
            get { return numberOfemployeesManaged; }
            set { numberOfemployeesManaged = value; }
        }
        //constructor
        public Manager() : base("n/a", -1){}
        public Manager(string aName, int aSalary, int aNumberOfemployeesManaged)
        {
            Name = aName ;
            Salary= aSalary ;
            NumberOfemployeesManaged= aNumberOfemployeesManaged ;
        }
        //ToString method 
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: {Salary}, Number of employees managed: {NumberOfemployeesManaged}";
        }
    }
    //subclass
    public class Engineer : Employee
    {
        //define variable only in engineer
        private string specialization = "n/a";
        //getset
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
        //constructor
        public Engineer() : base("n/a", -1) { }
        public Engineer(string aName, int aSalary, string Specialization)
        {
            Name = aName;
            Salary = aSalary;
            this.Specialization = Specialization;
        }
        //ToString method
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: {Salary}, Specialization: {Specialization}";
        }
    }
}
