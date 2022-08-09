namespace _2ND_Backend_Exam.API.DTOs.MaterialTypeDTOs
{
    public class MaterialTypePostDTO
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Type { get; set; } = null!;
    }
}
