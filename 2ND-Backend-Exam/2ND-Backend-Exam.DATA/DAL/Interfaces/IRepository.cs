namespace _2ND_Backend_Exam.DATA.DAL.Interfaces
{
    internal interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> SaveChangesAsync();
    }
}
