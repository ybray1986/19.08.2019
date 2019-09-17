namespace BusinessLayer.DataTransferObjects
{
    public class BooksDTO
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
