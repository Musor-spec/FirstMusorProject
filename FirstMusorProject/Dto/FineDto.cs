namespace FirstMusorProject.Dto
{
    public class FineDto
    {
        public int FineId { get; set; }
        public int ReaderId { get; set; }
        public int? BorrowingId { get; set; }
        public decimal FineAmount { get; set; }
        public string Reason { get; set; } = null!;
        public DateOnly IssueDate { get; set; }
        public DateOnly? PaidDate { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
