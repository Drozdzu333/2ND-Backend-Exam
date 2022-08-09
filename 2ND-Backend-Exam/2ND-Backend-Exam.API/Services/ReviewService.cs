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

        public async Task<ReviewDTO> CreateNewAsync(ReviewPostDTO value)
        {
            if (!await _repository.MaterialExistByIdAsync(value.EduMaterialId))
                throw new ResourceNotFoundException($"Material with id{value.EduMaterialId} not found");
            var review = _mapper.Map<Review>(value);
            await _repository.CreateAsync(review);
            await _repository.SaveChangesAsync();
            return _mapper.Map<ReviewDTO>(review);
        }

        public async Task<IEnumerable<ReviewDTO>> GetAllAsync()
        {
            var reviewList = await _repository.GetAllAsync();
            if (reviewList.Count() <= 0)
                throw new EmptyResourceListException("AuthorServicecs.GetAllAsync()");
            return _mapper.Map<IEnumerable<ReviewDTO>>(reviewList);
        }

        public async Task<ReviewDTO> GetByIdAsync(int id)
        {
            var revew = await _repository.GetByIdAsync(id);
            if (revew == null)
                throw new ResourceNotFoundException("");
            return _mapper.Map<ReviewDTO>(revew);
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
            var review = await _repository.GetByIdAsync(id);
            if (review == null)
                throw new ResourceNotFoundException("");
            if(value.NameOfAuthor != null)
                review.NameOfAuthor = value.NameOfAuthor;
            if(value.Description != null)
                review.Description = value.Description;
            if (value.Rate != null && value.Rate > 0)
                review.Rate = (int)value.Rate;
            return _mapper.Map<ReviewDTO>(review);
        }

        public async Task<ReviewDTO> UpdatePut(ReviewPutDTO value)
        {
            var review = await _repository.GetByIdAsync(value.Id);
            if (review == null)
                throw new ResourceNotFoundException("");
            review.NameOfAuthor = value.NameOfAuthor;
            review.Description = value.Description;
            review.Rate = (int)value.Rate;
            _repository.Update(review);
            await _repository.SaveChangesAsync();
            return _mapper.Map<ReviewDTO>(review);
        }
    }
}
