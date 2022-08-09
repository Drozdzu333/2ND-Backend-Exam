namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    public class EduMaterialRepository : Repository<EduMaterial>, IEduMaterialRepository
    {
        public EduMaterialRepository(EduContext context) : base(context) { }

        public async Task<EduMaterial> GetByIdAsync(int id)
            => await _entity
            .Include(edu=>edu.Author)
            .Include(edu=>edu.MaterialType)
            .Include(edu=>edu.Reviews)
            .SingleOrDefaultAsync(edu=>edu.AuthorId == id);

        public new async Task<IEnumerable<EduMaterial>> GetAllAsync()
            => await _entity
            .Include(edu => edu.Author)
            .Include(edu => edu.MaterialType)
            .Include(edu => edu.Reviews)
            .ToListAsync();

        public async Task<bool> ValidExistsSubIdsAsync(EduMaterial material)
        {
            var author = await _context.Authors.AnyAsync(author=>author.Id == material.AuthorId);
            var matTyp = await _context.MaterialTypes.AnyAsync(type=>type.Id == material.MaterialTypeId);
            return matTyp && author;
        }

        public async Task<Review> GetReviewByIdAsync(int id)
            => await _context.Reviews.SingleOrDefaultAsync(rev=>rev.Id == id);
    }
}
