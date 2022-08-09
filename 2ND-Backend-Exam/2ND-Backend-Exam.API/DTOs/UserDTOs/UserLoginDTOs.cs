namespace _2ND_Backend_Exam.API.DTOs.UserDTOs
{
    public class UserLoginDTO
    {
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
