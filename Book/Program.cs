using System;
namespace Book
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an array to hold the books
            Book[] books = new Book[2];

            // Insert information for the first book
            Console.WriteLine("Information of book 1:");
            Console.Write("Input name of the book: ");
            string title1 = Console.ReadLine();
            Console.Write("Input the author: ");
            string author1 = Console.ReadLine();

            // Create a book object and assign the provided information
            Book book1 = new Book();
            book1.Title = title1;
            book1.Author = author1;

            // Insert the first book into the array
            books[0] = book1;

            // Insert information for the second book
            Console.WriteLine("\nInformation of book 2:");
            Console.Write("Input name of the book: ");
            string title2 = Console.ReadLine();
            Console.Write("Input the author: ");
            string author2 = Console.ReadLine();

            // Create a book object and assign the provided information
            Book book2 = new Book();
            book2.Title = title2;
            book2.Author = author2;

            // Insert the second book into the array
            books[1] = book2;

            // Display the information of the inserted books
            Console.WriteLine("\nExpected Output:");
            for (int i = 0; i < books.Length; i++)
            {
                Book currentBook = books[i];
                Console.WriteLine($"{i + 1}: Title = {currentBook.Title}, Author = {currentBook.Author}");
            }

            Console.ReadLine();
        }
    }
}