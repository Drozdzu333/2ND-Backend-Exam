namespace _2ND_Backend_Exam.API.DTOs.AuthorDTOs
{
    public class AuthorPostDTO
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; } = null!;
        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string Description { get; set; } = null!;
    }
}
