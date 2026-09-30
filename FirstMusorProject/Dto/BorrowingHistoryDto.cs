namespace FirstMusorProject.Dto
{
    public class BorrowingHistoryDto
    {
        public long HistoryId { get; set; }
        public int BorrowingId { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public int CopyId { get; set; }
        public DateOnly BorrowDate { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly? ActualReturnDate { get; set; }
        public int? DaysOverdue { get; set; }
        public decimal? FineAmount { get; set; }
        public string OperationType { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
