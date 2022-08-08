namespace _2ND_Backend_Exam.DATA.Entities
{
    public class Review : BaseEntity
    {
        public string NameOfAuthor { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        
        public EduMaterial EduMaterial { get; set; }
        public int EduMaterialId { get; set; }
    }
}
