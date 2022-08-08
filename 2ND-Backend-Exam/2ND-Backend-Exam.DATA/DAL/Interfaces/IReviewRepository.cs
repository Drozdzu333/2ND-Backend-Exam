namespace _2ND_Backend_Exam.DATA.DAL.Interfaces
{
    public interface IReviewRepository : IRepository<Review>
    {
        Task<Review> GetByIdAsync(int id);
    }
}
