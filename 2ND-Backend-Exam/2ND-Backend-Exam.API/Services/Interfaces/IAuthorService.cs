namespace _2ND_Backend_Exam.API.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAsync();
        Task<AuthorDTO> GetByIdAsync(int id);
        Task<AuthorDTO> CreateNewAsync(AuthorPostDTO value);
        Task<AuthorDTO> UpdatePatch(int id, AuthorPatchDTO value);
        Task<bool> Remove(int id);
        Task<AuthorDTO> UpdatePut(AuthorPutDTO value);
        Task<IEnumerable<AuthorDTO>> GetAllBestsAsync();
    }
}
