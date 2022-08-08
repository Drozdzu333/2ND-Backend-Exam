namespace _2ND_Backend_Exam.API.DTOs.EduMaterialsDTOs
{
    public class EduMaterialDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime PublicationDate { get; set; }

        public AuthorDTO Author { get; set; }
        public MaterialTypeDTO MaterialType { get; set; }
        public IEnumerable<ReviewDTO> Reviews { get; set; }
    }
}
