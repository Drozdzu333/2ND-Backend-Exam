
namespace _2ND_Backend_Exam.API.DTOs.AuthorDTOs

{
    public class AuthorDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<AuthorMaterialDTO> Materials { get; set; }
    }
}
