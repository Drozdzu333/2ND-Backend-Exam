namespace _2ND_Backend_Exam.DATA.DAL.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<bool> ExistByIdAsync(int id);
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> SaveChangesAsync();
    }
}
