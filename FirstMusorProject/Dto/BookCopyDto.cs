using FirstMusorProject.Entities;

namespace FirstMusorProject.Dto
{
    public class BookCopyDto
    {
        public int CopyId { get; set; }
        public int BookId { get; set; }
        public string CopyNumber { get; set; } = null!;
        public string? ShelfLocation { get; set; }
        public string? Condition { get; set; }
        public bool? IsAvailable { get; set; }
        public DateOnly? AcquiredDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Book Book { get; set; } = null!;
    }
}
