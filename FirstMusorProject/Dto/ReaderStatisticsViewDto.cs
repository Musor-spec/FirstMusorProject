namespace FirstMusorProject.Dto
{
    public class ReaderStatisticsViewDto
    {
        public int ReaderId { get; set; }
        public string? ReaderName { get; set; }
        public long TotalBooksRead { get; set; }
        public long TotalBorrowings { get; set; }
        public DateOnly? LastReturnDate { get; set; }
        public decimal? TotalFines { get; set; }
    }
}
