namespace WebApplication1.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public string? Img { get; set; }

        public Book(string title, string author, string genre, decimal price, string src)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            Genre = genre;
            Price = price;
            Img = src;
        }

    }
}
