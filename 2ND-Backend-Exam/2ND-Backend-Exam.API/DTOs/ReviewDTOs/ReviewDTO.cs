namespace _2ND_Backend_Exam.API.DTOs.ReviewDTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; } = 0!;
        public string NameOfAuthor { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Rate { get; set; } = 0!;
        public ReviewEduMaterialDTO EduMaterial { get; set; } = null!;
    }
}
