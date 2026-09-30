namespace FirstMusorProject.Dto
{
    public class CurrentBorrowingViewDto
    {
        public int BorrowingId { get; set; }
        public int ReaderId { get; set; }
        public string? ReaderName { get; set; }
        public string BookTitle { get; set; } = null!;
        public string CopyNumber { get; set; } = null!;
        public DateOnly BorrowDate { get; set; }
        public DateOnly DueDate { get; set; }
        public string? Status { get; set; }
        public int? DaysOverdue { get; set; }
    }
}
