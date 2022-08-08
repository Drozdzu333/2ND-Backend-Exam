namespace _2ND_Backend_Exam.DATA.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<EduMaterial> Materials { get; set; }
        
    }
}
