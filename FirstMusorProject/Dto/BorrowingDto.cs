namespace FirstMusorProject.Dto
{
    public class BorrowingDto
    {
        public int BorrowingId { get; set; }
        public int ReaderId { get; set; }
        public int CopyId { get; set; }
        public DateOnly BorrowDate { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly? ReturnDate { get; set; }
        public string? Status { get; set; }
        public decimal? FineAmount { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
