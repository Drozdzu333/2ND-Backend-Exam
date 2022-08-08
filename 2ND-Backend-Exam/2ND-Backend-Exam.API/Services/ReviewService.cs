namespace _2ND_Backend_Exam.API.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _repository;
        private readonly IMapper _mapper;
        public ReviewService(IReviewRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ReviewDTO> CreateNewAsync(ReviewPutDTO value)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ReviewDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ReviewDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Remove(int id)
        {
            var review = await _repository.GetByIdAsync(id);
            if (review == null)
                throw new ResourceNotFoundException("");
            _repository.Delete(review);
            await _repository.SaveChangesAsync();
            return true;
        }

        public async Task<ReviewDTO?> UpdatePatch(int id, ReviewPatchDTO value)
        {
            throw new NotImplementedException();
        }

        public async Task<ReviewDTO> UpdatePut(ReviewPutDTO value)
        {
            throw new NotImplementedException();
        }
    }
}
