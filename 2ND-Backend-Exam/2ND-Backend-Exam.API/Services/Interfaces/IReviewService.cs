namespace _2ND_Backend_Exam.API.Services.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewDTO>> GetAllAsync();
        Task<ReviewDTO> GetByIdAsync(int id);
        Task<ReviewDTO> CreateNewAsync(ReviewPutDTO value);
        Task<ReviewDTO?> UpdatePatch(int id, ReviewPatchDTO value);
        Task<ReviewDTO> UpdatePut(ReviewPutDTO value);
        Task<bool> Remove(int id);
    }
}
