namespace BusinessLayer.DataTransferObjects
{
    using System;

    public class LibraryDTO
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
