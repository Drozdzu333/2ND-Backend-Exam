namespace _2ND_Backend_Exam.API.Services.Interfaces
{
    public interface IMaterialTypeService
    {
        Task<IEnumerable<MaterialTypeDTO>> GetAllAsync();
        Task<MaterialTypeDTO> GetByIdAsync(int id);
        Task<MaterialTypeDTO> CreateNewAsync(MaterialTypePostDTO value);
        Task<MaterialTypeDTO> UpdatePut(MaterialTypePutDTO value);
        Task<bool> Remove(int id);
        Task<IEnumerable<EduMaterialDTO>> GetAllByTypeAsync(int id);
    }
}
