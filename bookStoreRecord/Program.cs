using System;
namespace bookStoreRecord
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            var book1 = new Bookstore(1, "Maze Runner", "James Dashner", 10.99);
            var book2 = new Bookstore(2, "Chronicles of Narnia", "C.S. Lewis", 8.99);
            var book3 = new Bookstore(3, "Frankenstein", "Mary Shelley", 12.99);
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
        }
    }
}