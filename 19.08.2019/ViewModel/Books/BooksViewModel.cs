using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19._08._2019.ViewModel.Books
{
    public class BooksViewModel
    {
        private int authorId;
        private int genreId;
        public int Id { get; set; }
        public string AuthorFullName { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }
        public int? Price { get; set; }
        public string GenreName { get; set; }
    }
}