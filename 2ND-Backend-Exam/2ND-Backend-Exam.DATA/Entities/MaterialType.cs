namespace _2ND_Backend_Exam.DATA.Entities
{
    public class MaterialType : BaseEntity
    {
        public string Type { get; set; }

        public List<EduMaterial> EduMaterials { get; set; }
    }
}