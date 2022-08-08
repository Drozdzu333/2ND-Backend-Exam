namespace _2ND_Backend_Exam.DATA.Entities
{
    public class Review : BaseEntity
    {
        public string NameOfAuthor { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Rate { get; set; } = 0!;

        public EduMaterial EduMaterial { get; set; } = null!;
        public int EduMaterialId { get; set; }
    }
}
