namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
