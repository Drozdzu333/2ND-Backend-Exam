namespace _2ND_Backend_Exam.DATA.DAL.Interfaces
{
    public interface IMaterialTypeRepository : IRepository<MaterialType>
    {
        Task<MaterialType> GetByIdAsync(int id);

    }
}
