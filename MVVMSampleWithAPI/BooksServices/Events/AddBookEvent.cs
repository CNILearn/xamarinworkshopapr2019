using BooksServices.Models;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksServices.Events
{
    public class AddBookEvent : PubSubEvent<Book>
    {
    }
}
