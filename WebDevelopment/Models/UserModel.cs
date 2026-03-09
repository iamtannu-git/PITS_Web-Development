namespace WebDevelopment.Models
    {
    public class UserModel
    {
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string Password { get; set; } = string.Empty;

        public string? Address { get; set; }

        public DateTime RecDate { get; set; }

        public int Status { get; set; } = 1;
    }
}
