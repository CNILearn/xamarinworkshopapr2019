using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.Models
{
    public class Book
    {
        public int BookId { get; set; }
        
        public string Title { get; set; }
        [MaxLength(40)]
        public string Publisher { get; set; }
        public string Isbn { get; set; }
    }
}
