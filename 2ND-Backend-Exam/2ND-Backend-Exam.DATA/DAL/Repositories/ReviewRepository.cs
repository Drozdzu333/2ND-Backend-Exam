namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(EduContext context) : base(context) { }

        public async Task<Review> GetByIdAsync(int id)
            => await _entity.Include(review=>review.EduMaterial).SingleOrDefaultAsync(x => x.Id == id);
        public new async Task<IEnumerable<Review>> GetAllAsync()
            => await _entity.Include(review => review.EduMaterial).ToListAsync();
    }
}
