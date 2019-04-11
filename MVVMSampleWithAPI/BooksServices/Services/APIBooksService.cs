using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BooksServices.Models;
using Newtonsoft.Json;

namespace BooksServices.Services
{
    public class APIBooksService : IBooksService
    {
        private readonly HttpClient _httpClient;
        public APIBooksService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            var response = await _httpClient.GetAsync("api/Books");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<Book>>(json);


            //// C# 8
            //using HttpClient client = new HttpClient();
            //var response = await client.GetAsync("");
            //response.EnsureSuccessStatusCode();
            //string json = await response.Content.ReadAsStringAsync();
            //return JsonConvert.DeserializeObject<IEnumerable<Book>>(json);

        }
    }
}
