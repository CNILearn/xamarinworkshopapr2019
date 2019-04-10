using System;
using System.Collections.Generic;
using System.Text;

namespace BooksServices
{
    public class BookFactory
    {
        private List<Book> _books = new List<Book>()
        {
            new Book { BookId = 1, Title = "Beginning C#", Publisher = "Wrox Press", Authors = new [] {"Karli Watson", "Christian Nagel" } },
            new Book { BookId = 2, Title = "Professional C#", Publisher = "Wrox Press", Authors = new [] {"Christian Nagel" } },
            new Book { BookId = 3, Title = "Enterprise Services", Publisher = "AWL", Authors = new [] { "Christian Nagel" } },
        };

        public IEnumerable<Book> GetBooks() => _books;
    }
}
