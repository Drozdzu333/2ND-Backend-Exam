namespace _2ND_Backend_Exam.API.DTOs.EduMaterialsDTOs
{
    public class EduMaterialDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime PublicationDate { get; set; }
        public string Author { get; set; } = null!;
        public string MaterialType { get; set; } = null!;
    }
}
