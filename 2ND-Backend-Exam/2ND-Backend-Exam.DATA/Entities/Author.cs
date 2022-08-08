namespace _2ND_Backend_Exam.DATA.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<EduMaterial> Materials { get; set; }
        
    }
}
