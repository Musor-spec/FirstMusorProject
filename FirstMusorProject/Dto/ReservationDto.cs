namespace FirstMusorProject.Dto
{
    public class ReservationDto
    {
        public int ReservationId { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public DateTime? ReservationDate { get; set; }
        public string? Status { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public bool? NotificationSent { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
