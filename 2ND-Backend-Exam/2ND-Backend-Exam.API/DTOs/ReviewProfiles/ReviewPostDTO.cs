namespace _2ND_Backend_Exam.API.DTOs.ReviewProfiles
{
    public class ReviewPostDTO
    {
        [Required]
        public string NameOfAuthor { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public int Rate { get; set; } = 0!;

        [Required]
        [Range(1, int.MaxValue)]
        public int EduMaterialId { get; set; }
    }
}
