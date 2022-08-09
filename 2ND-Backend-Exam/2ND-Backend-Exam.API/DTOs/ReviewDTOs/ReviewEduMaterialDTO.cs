namespace _2ND_Backend_Exam.API.DTOs.ReviewDTOs
{
    public class ReviewEduMaterialDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime PublicationDate { get; set; }
    }
}
