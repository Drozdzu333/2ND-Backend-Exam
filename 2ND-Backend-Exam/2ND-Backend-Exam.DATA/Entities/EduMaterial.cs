namespace _2ND_Backend_Exam.DATA.Entities
{
    public class EduMaterial : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime PublicationDate { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public MaterialType MaterialType { get; set; }
        public int MaterialId { get; set; }

        public IEnumerable<Review> Reviews { get; set; }


    }
}
