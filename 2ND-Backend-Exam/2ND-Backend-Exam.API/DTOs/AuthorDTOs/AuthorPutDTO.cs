
namespace _2ND_Backend_Exam.API.DTOs.AuthorDTOs
{
    public class AuthorPutDTO
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; } = 0!;
        [Required]
        [MinLength(2)]
        public string Name { get; set; } = null!;
        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string Description { get; set; } = null!;

        public IEnumerable<int>? MaterialsIds { get; set; }
    }
}
