using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19._08._2019.ViewModel.Library
{
    public class LibraryViewModel
    {
        private int userId;
        private int bookId;
        public int ID { get; set; }
        public string UserFullName { get; set; }
        public string BookTitle { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime ReturnedDate { get; set; }
    }
}