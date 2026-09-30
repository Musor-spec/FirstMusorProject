namespace FirstMusorProject.Dto
{
    public class LibraryCardDto
    {
        public int CardId { get; set; }
        public int ReaderId { get; set; }
        public string CardNumber { get; set; } = null!;
        public DateOnly IssueDate { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public string? Status { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
