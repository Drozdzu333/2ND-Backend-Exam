namespace _2ND_Backend_Exam.API.Services
{
    public class MaterialTypeService : IMaterialTypeService
    {
        private readonly IMaterialTypeRepository _repository;
        private readonly IMapper _mapper;

        public MaterialTypeService(IMaterialTypeRepository materialTypeRepository, IMapper mapper)
        {
            _repository = materialTypeRepository;
            _mapper = mapper;
        }
        public async Task<MaterialTypeDTO> CreateNewAsync(MaterialTypePostDTO value)
        {
            var matType = _mapper.Map<MaterialType>(value);
            await _repository.CreateAsync(matType);
            await _repository.SaveChangesAsync();
            return _mapper.Map<MaterialTypeDTO>(matType);
        }

        public async Task<IEnumerable<MaterialTypeDTO>> GetAllAsync()
        {
            var matTypeList = await _repository.GetAllAsync();
            if (matTypeList.Count() <= 0)
                throw new EmptyResourceListException("MaterialTypeService.GetAllAsync()");
            return _mapper.Map<IEnumerable<MaterialTypeDTO>>(matTypeList);
        }

        public async Task<MaterialTypeDTO> GetByIdAsync(int id)
        {
            var matType = await _repository.GetByIdAsync(id);
            if (matType == null)
                throw new ResourceNotFoundException($"MaterialTypeService.GetByIdAsync({id})");
            return _mapper.Map<MaterialTypeDTO>(matType);
        }

        public async Task<bool> Remove(int id)
        {
            var materialType = await _repository.GetByIdAsync(id);
            if (materialType == null)
                throw new ResourceNotFoundException("");
            _repository.Delete(materialType);
            await _repository.SaveChangesAsync();
            return true;
        }
        public async Task<MaterialTypeDTO> UpdatePut(MaterialTypePutDTO value)
        {
            var matType = await _repository.GetByIdAsync(value.Id);
            if (matType == null)
                throw new ResourceNotFoundException("");
            matType.Type = value.Type;
            _repository.Update(matType);
            await _repository.SaveChangesAsync();
            return _mapper.Map<MaterialTypeDTO>(matType);
        }
    }
}
