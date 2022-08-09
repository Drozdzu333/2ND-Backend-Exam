namespace _2ND_Backend_Exam.DATA.DAL.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetByIdAsync(int id);
        Task<EduMaterial> GetMaterialByIdAsync(int eduMaterialId);
        Task<IEnumerable<Author>> GetAllBestsAsync();
    }
}
