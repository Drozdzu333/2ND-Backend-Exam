namespace _2ND_Backend_Exam.DATA.DAL.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByLoginAndPassword(string login, string password);
        string HashPassword(string password);
    }
}
