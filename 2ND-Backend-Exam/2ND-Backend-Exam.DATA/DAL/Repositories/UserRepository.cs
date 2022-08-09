namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(EduContext context) : base(context) { }


        public new async Task CreateAsync(User user)
        {
            user.Password = HashPassword(user.Password);
            await _entity.AddAsync(user);
        }
        public User GetUserByLoginAndPassword(string login, string password)
            => _entity.SingleOrDefault(user=>user.Username == login && user.Password == HashPassword(password));

        public string HashPassword(string password)
        {
            var hash = SHA256.Create();
            var passwordBytes = Encoding.Default.GetBytes(password);
            var hashedPassword = hash.ComputeHash(passwordBytes);
            var stringToReturn = Convert.ToHexString(hashedPassword);
            return stringToReturn;
        }
    }
}
