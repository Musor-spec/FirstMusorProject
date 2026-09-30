namespace FirstMusorProject.Dto
{
    public class AuthorDto
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; } = null!;
        public int? BirthYear { get; set; }
        public int? DeathYear { get; set; }
        public string? Biography { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
