namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(EduContext context) : base(context) { }

        public async Task<Author> GetByIdAsync(int id)
            => await _entity.Include(author => author.Materials).SingleOrDefaultAsync(x => x.Id == id);

        public async Task<EduMaterial> GetMaterialByIdAsync(int eduMaterialId)
            => await _context.EduMaterials.SingleOrDefaultAsync(x => x.Id == eduMaterialId);

        public new async Task<IEnumerable<Author>> GetAllAsync()
            => await _entity.Include(author => author.Materials).ToListAsync();
        public async Task<IEnumerable<EduMaterial>> SomeFunction()
            => await _context.EduMaterials
            .Where(x =>x.Reviews.Average(rev => rev.Rate) >= 5.0)
            .ToListAsync();

        private static IEnumerable<Review> GetReviews(IEnumerable<EduMaterial> x)
            => (IEnumerable<Review>) x.Select(x=>x.Reviews).ToList();

        public async Task<IEnumerable<Author>> GetAllBestsAsync()
            => await _entity
            .Include(auth => auth.Materials)
            .Where(author => GetReviews(author.Materials).Average(rev => rev.Rate) >= 5)
            .ToListAsync();
    }
}
    