namespace FirstMusorProject.Dto
{
    public class ReaderDto
    {
        public int ReaderId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Patronymic { get; set; }
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string PasswordHash { get; set; } = null!;
        public DateOnly? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
