namespace FirstMusorProject.Dto
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string? Isbn { get; set; }
        public string Title { get; set; } = null!;
        public short? PublicationYear { get; set; }
        public string? Publisher { get; set; }
        public int? Pages { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        public string? CoverImageUrl { get; set; }
        public int? TotalCopies { get; set; }
        public int? AvailableCopies { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
