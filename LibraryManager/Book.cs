using System;

namespace LibraryManager
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }=true; 

        public Book()
        {
        }

        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        public override string ToString()
        {
            return string.Format($"{Title}\t{Author}\t{ISBN}");
        }
    }
}
