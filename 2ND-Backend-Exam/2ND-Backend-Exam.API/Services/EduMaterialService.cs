namespace _2ND_Backend_Exam.API.Services
{
    public class EduMaterialService : IEduMaterialService
    {
        private readonly IEduMaterialRepository _repository;
        private readonly IMapper _mapper;
        public EduMaterialService(IEduMaterialRepository materialRepository, IMapper mapper)
        {
            _repository = materialRepository;
            _mapper = mapper;
        }
        public async Task<EduMaterialDTO> CreateNewAsync(EduMaterialPostDTO value)
        {
            var material = _mapper.Map<EduMaterial>(value);
            if (! await _repository.ValidExistsSubIdsAsync(material))
                throw new ResourceNotFoundException("Author or type not found");
            await _repository.CreateAsync(material);
            await _repository.SaveChangesAsync();
            return _mapper.Map<EduMaterialDTO>(material);
        }

        public async Task<IEnumerable<EduMaterialDTO>> GetAllAsync()
        {
            var eduMaterialsList = await _repository.GetAllAsync();
            if (eduMaterialsList.Count() <= 0)
                throw new EmptyResourceListException("EduMaterialService.GetAllAsync()");
            return _mapper.Map<IEnumerable<EduMaterialDTO>>(eduMaterialsList);
        }

        public async Task<EduMaterialDTO> GetByIdAsync(int id)
        {
            var material = _repository.GetByIdAsync(id);
            if (material == null)
                throw new ResourceNotFoundException("");
            return _mapper.Map<EduMaterialDTO>(material);
        }

        public async Task<bool> Remove(int id)
        {
            var material = await _repository.GetByIdAsync(id);
            if(material == null)
                throw new ResourceNotFoundException("");
            _repository.Delete(material);
            await _repository.SaveChangesAsync();
            return true;
        }

        public async Task<EduMaterialDTO> UpdatePatch(int id, EduMaterialPatchDTO value)
        {
            var material = await _repository.GetByIdAsync(id);
            if (material == null)
                throw new ResourceNotFoundException("");
            await PatchMaterialAsync(value, material);
            return _mapper.Map<EduMaterialDTO>(material);
        }

        public async Task<EduMaterialDTO> UpdatePut(EduMaterialPutDTO value)
        {
            var material = await _repository.GetByIdAsync(value.Id);
            if (material == null)
                throw new ResourceNotFoundException("");
            PutMaterialAsync(value, material);
            return _mapper.Map<EduMaterialDTO>(material);
        }
        private async Task PutMaterialAsync(EduMaterialPutDTO source, EduMaterial result)
        {

            result.Title = source.Title;
            result.Description = source.Description;
            result.Location = source.Location;
            result.PublicationDate = (DateTime)source.PublicationDate;
            result.AuthorId = (int)source.AuthorId;
            result.MaterialTypeId = (int)source.MaterialTypeId;
            await UpdateReviews(result, source.ReviewsIds);
        }
        private async Task PatchMaterialAsync(EduMaterialPatchDTO source, EduMaterial result)
        {
            if (source.Title != null)
                result.Title = source.Title;

            if (source.Description != null)
                result.Description = source.Description;

            if (source.Location != null)
                result.Location = source.Location;

            if (source.PublicationDate != null)
                result.PublicationDate = (DateTime)source.PublicationDate;

            if (source.AuthorId != null)
                result.AuthorId = (int)source.AuthorId;

            if (source.MaterialTypeId != null)
                result.MaterialTypeId = (int)source.MaterialTypeId;

            if (source.ReviewsIds != null)
                await UpdateReviews(result ,source.ReviewsIds);

        }
        private async Task UpdateReviews(EduMaterial eduMaterial, IEnumerable<int> reviewIds)
        {
            var newList = new List<Review>();
            foreach (var id in reviewIds)
            {
                Review review = await _repository.GetReviewByIdAsync(id);
                if (review != null)
                    newList.Add(review);
            }
            eduMaterial.Reviews = newList;
        }
    }
}
