namespace _2ND_Backend_Exam.API.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAsync();
        Task<AuthorDTO> GetByIdAsync(int id);
        Task<int> CreateNewAsync(AuthorPostDTO value);
        Task<AuthorDTO> UpdatePut(int id, AuthorPutDTO value);
        Task<bool> Remove(int id);
    }
}
