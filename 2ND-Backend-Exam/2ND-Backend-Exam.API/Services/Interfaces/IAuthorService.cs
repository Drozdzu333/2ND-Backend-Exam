namespace _2ND_Backend_Exam.API.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAsync();
        Task<AuthorDTO> GetByIdAsync(int id);
        Task<int> CreateNewAsync(AuthorPutDTO value);
        Task<AuthorDTO> UpdatePatch(int id, AuthorPatchDTO value);
        Task<bool> Remove(int id);
        Task<AuthorDTO> UpdatePut(AuthorPutDTO value);
    }
}
