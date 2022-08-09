namespace _2ND_Backend_Exam.DATA.DAL.Interfaces
{
    public interface IEduMaterialRepository : IRepository<EduMaterial>
    {
        public Task<EduMaterial> GetByIdAsync(int id);
        Task<bool> ValidExistsSubIdsAsync(EduMaterial material);
        Task<Review> GetReviewByIdAsync(int id);
    }
}
