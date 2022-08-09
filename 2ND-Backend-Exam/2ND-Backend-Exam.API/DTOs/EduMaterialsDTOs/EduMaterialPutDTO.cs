namespace _2ND_Backend_Exam.API.DTOs.EduMaterialsDTOs
{
    public class EduMaterialPutDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int MaterialTypeId { get; set; }
        [Required]
        public IEnumerable<int> ReviewsIds { get; set; }
    }
}
