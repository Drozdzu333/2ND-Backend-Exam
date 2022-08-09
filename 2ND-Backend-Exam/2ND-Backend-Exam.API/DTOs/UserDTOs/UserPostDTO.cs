namespace _2ND_Backend_Exam.API.DTOs.UserDTOs
{
    public class UserPostDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
