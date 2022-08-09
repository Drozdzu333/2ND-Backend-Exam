namespace _2ND_Backend_Exam.API.Services.Interfaces
{
    public interface IMaterialTypeService
    {
        Task<IEnumerable<MaterialTypeDTO>> GetAllAsync();
        Task<MaterialTypeDTO> GetByIdAsync(int id);
        Task<int> CreateNewAsync(MaterialTypePostDTO value);
        Task<MaterialTypeDTO> UpdatePut(MaterialTypePutDTO value);
        Task<MaterialTypeDTO> Remove(int id);
    }
}
