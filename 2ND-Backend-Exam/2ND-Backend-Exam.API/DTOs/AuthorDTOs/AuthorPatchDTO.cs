namespace _2ND_Backend_Exam.API.DTOs.AuthorDTOs
{
    public class AuthorPatchDTO
    {
        [MinLength(2)]
        [MaxLength(20)]
        public string? Name { get; set; }
        [MinLength(3)]
        [MaxLength(255)]
        public string? Description { get; set; }
        public IEnumerable<int>? MaterialsIds { get; set; }
    }
}
