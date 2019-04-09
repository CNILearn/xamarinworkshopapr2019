using System;
using System.Collections.Generic;
using System.Text;

namespace BooksServices
{
    public class BookFactory
    {
        public Book GetTheBook() => new Book { BookId = 1, Title = "Professional C# 7", Publisher = "Wrox Press" };
    }
}
