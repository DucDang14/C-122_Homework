//Written by Duc Anh Dang
//02/25/2025
namespace AnimalsAndSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object for base and sub class and priting out
            Console.WriteLine("Hello, World!");
            Animal animal = new Animal("chetah");
            Console.WriteLine(animal.ToString());
            Dog dog = new Dog("Meo");
            Console.WriteLine(dog.ToString());
            Cat cat = new Cat("Dog");
            Console.WriteLine(cat.ToString());
            Console.ReadLine();
        }
    }
}
