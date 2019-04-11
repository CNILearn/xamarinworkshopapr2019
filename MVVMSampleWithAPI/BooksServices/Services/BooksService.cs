using BooksServices.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BooksServices.Services
{
    public class BooksService : IBooksService
    {
        private List<Book> _books = new List<Book>()
        {
            new Book { BookId = 1, Title = "Beginning C#", Publisher = "Wrox Press", Authors = new [] {"Karli Watson", "Christian Nagel" } },
            new Book { BookId = 2, Title = "Professional C#", Publisher = "Wrox Press", Authors = new [] {"Christian Nagel" } },
            new Book { BookId = 3, Title = "Enterprise Services", Publisher = "AWL", Authors = new [] { "Christian Nagel" } },
        };

        public Task<IEnumerable<Book>> GetBooksAsync() =>
            Task.FromResult<IEnumerable<Book>>(_books);

    }
}
