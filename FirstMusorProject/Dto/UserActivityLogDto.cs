namespace FirstMusorProject.Dto
{
    public class UserActivityLogDto
    {
        public long LogId { get; set; }
        public int ReaderId { get; set; }
        public string ActivityType { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
