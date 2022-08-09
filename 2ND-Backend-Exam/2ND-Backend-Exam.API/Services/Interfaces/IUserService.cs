namespace _2ND_Backend_Exam.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> CreateNewAsync(UserPostDTO value);
    }
}
