namespace Application.Features.Books.ViewModels
{
    public class BookVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Isbn_10 { get; set; } = string.Empty;
        public string Isbn_13 { get; set; } = string.Empty;
        public int Rating { get; set; }

    }
}
