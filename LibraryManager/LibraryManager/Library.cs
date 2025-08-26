using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManager
{
    class Library
    {
       private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void ShowBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library");
                return;
            }

            var groupedBooks = books.GroupBy(b => b.IsAvailable);

            foreach (var group in groupedBooks)
            {
                Console.ForegroundColor = group.Key ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine(group.Key ? "Available Books:" : "Borrowed Books:");
                Console.ResetColor();

                foreach (var book in group)
                {
                    Console.WriteLine(book);
                }
            }
            Console.WriteLine();
        }
        public void BorrowBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book!= null&&book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine($"You have borrowed '{book.Title}' by {book.Author}.");
            }
            else
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"Sorry {book.Title} by {book.Author} is currently not available");
            }
            Console.ResetColor();
        }
        public void ReturnBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book!= null && !book.IsAvailable)
            {
                book.IsAvailable = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have returned '{book.Title}' by {book.Author}.");
            }
            else
            {
                Console.ForegroundColor=(ConsoleColor)ConsoleColor.Red;
                Console.WriteLine($"Book {title} not found in the library.");
            }
            Console.ResetColor ();
        }
    }
}
