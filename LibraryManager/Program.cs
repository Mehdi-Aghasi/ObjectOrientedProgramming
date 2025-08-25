using System;
using System.Collections.Generic;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            List<Book> books = new List<Book>
            {
                 new Book { Title = "Clean Code", Author = "Robert C. Martin", ISBN = "9780132350884" },
                 new Book { Title = "CLR via C#", Author = "Jeffrey Richter", ISBN = "9780735667457" },
                 new Book { Title = "The Pragmatic Programmer", Author = "Andrew Hunt & David Thomas", ISBN = "9780201616224" },
                 new Book { Title = "Design Patterns", Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", ISBN = "9780201633610" },
                 new Book { Title = "C# in Depth", Author = "Jon Skeet", ISBN = "9781617294532" }
            };
            foreach (Book book in books)
            {
                library.AddBook(book);
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Library Management System");
                Console.ResetColor();
                Console.WriteLine("1)AddBook");
                Console.WriteLine("2)BorrowBook");
                Console.WriteLine("3)ReturnBook");
                Console.WriteLine("4)ShowAllBook");
                Console.WriteLine("5)Exit");
                Console.Write("Choice a Number: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("nvalid input! Please enter a number");
                    continue;
                }


                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Please Enter Title Book: ");
                        string title = Console.ReadLine();
                        Console.Write("Please Enter Author Book: ");
                        string author = Console.ReadLine();
                        Console.Write("Please Enter ISBN Book: ");
                        string isbn = Console.ReadLine();
                        library.AddBook(new Book(title, author, isbn));
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter the Title of the book to borrow: ");
                        string borrowTitle = Console.ReadLine();
                        library.BorrowBook(borrowTitle);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter the Title of the book to return: ");
                        string returnTitle = Console.ReadLine();
                        library.ReturnBook(returnTitle);
                        break;
                    case 4:
                        Console.Clear();
                        library.ShowBook();
                        break;
                    case 5:
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Try again.");
                        Console.ResetColor();
                        break;

                }
            }
        }
    }
}
