using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void BorrowBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title));
            if (book == null)
            {
                Console.WriteLine($"Book {title} not found in the library.");
                return;
            }
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"You have borrowed '{book.Title}' by {book.Author}.");
            }
            else
            {
                Console.WriteLine($"Sorry {book.Title} by {book.Author} is currently not available");
            }
        }
        public void ReturnBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title));
            if (book == null)
            {
                Console.WriteLine($"Book {title} not found in the library.");
                return;
            }
            if (!book.IsAvailable)
            {
                book.IsAvailable = true;
                Console.WriteLine($"You have returned '{book.Title}' by {book.Author}.");
            }
            else
            {
                Console.WriteLine($"The book '{title}' was not borrowed from this library.");
            }
        }
    }
}
