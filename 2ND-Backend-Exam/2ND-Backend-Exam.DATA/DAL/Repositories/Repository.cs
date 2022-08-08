namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    internal class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly EduContext _context;
        private readonly DbSet<T> _entity;
        public Repository(EduContext context)
        {
            _context = context;
            _entity = context.Set<T>();

        }
        public void Create(T entity)
            => _entity.Add(entity);

        public void Delete(T entity)
            => _entity.Remove(entity);

        public async Task<IEnumerable<T>> GetAllAsync()
            => await _entity.ToListAsync();
        public async Task<bool> SaveChangesAsync()
            => await _context.SaveChangesAsync() > 0;

        public void Update(T entity)
            => _entity.Update(entity);
    }
}
