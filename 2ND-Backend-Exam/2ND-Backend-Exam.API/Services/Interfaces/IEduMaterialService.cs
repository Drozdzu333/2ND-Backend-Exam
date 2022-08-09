namespace _2ND_Backend_Exam.API.Services.Interfaces
{
    public interface IEduMaterialService
    {
        Task<IEnumerable<EduMaterialDTO>> GetAllAsync();
        Task<EduMaterialDTO> GetByIdAsync(int id);
        Task<EduMaterialDTO> CreateNewAsync(EduMaterialPostDTO value);
        Task<EduMaterialDTO> UpdatePatch(int id, EduMaterialPatchDTO value);
        Task<EduMaterialDTO> UpdatePut(EduMaterialPutDTO value);
        Task<bool> Remove(int id);
    }
}
