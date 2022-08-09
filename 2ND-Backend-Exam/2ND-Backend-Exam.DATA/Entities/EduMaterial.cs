namespace _2ND_Backend_Exam.DATA.Entities
{
    public class EduMaterial : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime PublicationDate { get; set; }

        public Author Author { get; set; } = null!;
        public int AuthorId { get; set; }

        public MaterialType MaterialType { get; set; } = null!;
        public int MaterialTypeId { get; set; }

        public IEnumerable<Review> Reviews { get; set; } = new List<Review>();
    }
}
