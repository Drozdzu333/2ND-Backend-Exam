namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public readonly EduContext _context;
        public readonly DbSet<T> _entity;
        public Repository(EduContext context)
        {
            _context = context;
            _entity = context.Set<T>();

        }
        public async Task CreateAsync(T entity)
            => await _entity.AddAsync(entity);

        public void Delete(T entity)
            => _entity.Remove(entity);

        public async Task<bool> ExistByIdAsync(int id)
            => await _entity.AnyAsync(x => x.Id == id);

        public async Task<IEnumerable<T>> GetAllAsync()
            => await _entity.ToListAsync();

        public async Task<bool> SaveChangesAsync()
            => await _context.SaveChangesAsync() > 0;

        public void Update(T entity)
            => _entity.Update(entity);
    }
}
