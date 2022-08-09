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
            throw new NotImplementedException();
        }

        public async Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EduMaterialDTO> UpdatePatch(int id, EduMaterialPatchDTO value)
        {
            throw new NotImplementedException();
        }

        public async Task<EduMaterialDTO> UpdatePut(EduMaterialPutDTO value)
        {
            throw new NotImplementedException();
        }
    }
}
