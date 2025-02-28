//Written by Duc Anh Dang
//02/25/2025
namespace EmployeesAndSpecializations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            //create object for each class and printing out
            Employee employee = new Employee("Dan", 100000);
            Console.WriteLine(employee.ToString());
            Manager manager = new Manager("Duc Anh", 300000, 50);
            Console.WriteLine(manager.ToString());
            Engineer engineer = new Engineer("Anh Dang", 500000, "Project Manager");
            Console.WriteLine(engineer.ToString());
            Console.ReadKey();
        }
    }
}
