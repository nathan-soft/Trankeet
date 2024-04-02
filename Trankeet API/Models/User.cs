namespace Trankeet_API.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }
    }
}
