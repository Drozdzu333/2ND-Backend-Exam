namespace _2ND_Backend_Exam.API.DTOs.EduMaterialsDTOs
{
    public class EduMaterialPatchDTO
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public DateTime? PublicationDate { get; set; }

        public Author? Author { get; set; }
        public int? AuthorId { get; set; }

        public int? MaterialTypeId { get; set; }

        public IEnumerable<int>? ReviewsId { get; set; }
    }
}
