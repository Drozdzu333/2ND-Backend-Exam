namespace _2ND_Backend_Exam.DATA.Entities
{
    public class MaterialType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }

        public List<EduMaterial> EduMaterials { get; set; }
    }
}
