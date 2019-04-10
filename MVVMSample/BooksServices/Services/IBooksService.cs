using System.Collections.Generic;
using System.Threading.Tasks;
using BooksServices.Models;

namespace BooksServices.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetBooksAsync();
    }
}