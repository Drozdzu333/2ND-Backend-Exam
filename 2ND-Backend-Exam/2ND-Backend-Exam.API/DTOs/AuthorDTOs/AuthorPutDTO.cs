
namespace _2ND_Backend_Exam.API.DTOs.AuthorDTOs
{
    public class AuthorPutDTO
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string Description { get; set; }
        [Range(1, int.MaxValue)]
        public IEnumerable<int>? MaterialsIds { get; set; }
    }
}
