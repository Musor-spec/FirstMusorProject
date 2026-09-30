namespace FirstMusorProject.Dto
{
    public class GenreDto
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
