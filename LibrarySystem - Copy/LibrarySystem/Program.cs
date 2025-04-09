//Written by Duc Anh Dang
//02/25/2025
namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object for base and 2 subclass and priting out
            Console.WriteLine("Hello, World!");
            Book book = new Book("Atomic Habit", "Duw", 2012);
            Console.WriteLine(book.ToString());
            EBook eBook = new EBook("Dw", "EC", 2030, 56);
            Console.WriteLine(eBook.ToString());
            PrintedBook printedBook = new PrintedBook("AE", "MD", 2050, 856);
            Console.WriteLine(printedBook.ToString());
            Console.ReadKey();
        }
    }
}
