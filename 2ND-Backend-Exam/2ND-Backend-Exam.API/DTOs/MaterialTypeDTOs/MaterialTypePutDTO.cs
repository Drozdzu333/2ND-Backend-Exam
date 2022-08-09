namespace _2ND_Backend_Exam.API.DTOs.MaterialTypeDTOs
{
    public class MaterialTypePutDTO
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Type { get; set; } = null!;
    }
}
