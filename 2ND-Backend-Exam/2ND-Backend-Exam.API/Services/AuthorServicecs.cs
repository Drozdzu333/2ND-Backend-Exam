namespace _2ND_Backend_Exam.API.Services
{
    public class AuthorServicecs : IAuthorService
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;
        public AuthorServicecs(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> CreateNewAsync(AuthorPostDTO value)
        {
            var author = _mapper.Map<Author>(value);
            await _repository.CreateAsync(author);
            await _repository.SaveChangesAsync();
            return author.Id;
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAsync()
        {
            var authorsList = await _repository.GetAllAsync();
            if (authorsList.Count() <= 0)
                throw new EmptyResourceListException("AuthorServicecs.GetAllAsync()");
            return _mapper.Map<IEnumerable<AuthorDTO>>(authorsList);

        }

        public async Task<AuthorDTO> GetByIdAsync(int id)
        {
            var author = await _repository.GetByIdAsync(id);
            if (author == null)
                throw new ResourceNotFoundException($"AuthorServicecs.GetByIdAsync({id})");
            return _mapper.Map<AuthorDTO>(author);
        }

        public async Task<bool> Remove(int id)
        {
            var author = await _repository.GetByIdAsync(id);
            if (author == null)
                throw new ResourceNotFoundException($"AuthorServicecs.Remove({id})");
            _repository.Delete(author);
            await _repository.SaveChangesAsync();
            return true;
        }

        public async Task<AuthorDTO> UpdatePut(int id, AuthorPutDTO value)
        {
            if (value == null)
                throw new EmptyPutRequestException($"AuthorServicecs.UpdatePut{id}");
            if(value.Name == null && value.Description == null && value.MaterialsIds == null)
                throw new EmptyPutRequestException($"AuthorServicecs.UpdatePut{id}");
            var author = await _repository.GetByIdAsync(id);
            if (author == null)
                throw new ResourceNotFoundException($"AuthorServicecs.UpdatePut({id})");
            await UpdateAuthorAsync(value, author);
            _repository.Update(author);
            await _repository.SaveChangesAsync();
            return _mapper.Map<AuthorDTO>(author);
        }
        private async Task UpdateAuthorAsync(AuthorPutDTO source, Author result)
        {
            if(source.Name != null)
                result.Name = source.Name;
            if(source.Description != null)
                result.Description = source.Description;
            if (source.MaterialsIds != null)
                await UpdateMaterials(result, source.MaterialsIds);
        }
        private async Task UpdateMaterials(Author author, IEnumerable<int> materialIds)
        {
        var newList = new List<EduMaterial>();
            foreach(var id in materialIds)
            {
                var material = await _repository.GetMaterialByIdAsync(id);
                if(material != null)
                    newList.Add(material);
            }
        author.Materials = newList;
        }
    }
}
