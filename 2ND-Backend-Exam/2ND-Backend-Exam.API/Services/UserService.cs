namespace _2ND_Backend_Exam.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _repository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> CreateNewAsync(UserPostDTO value)
        {
            var admin = _mapper.Map<User>(value);
            admin.Role = "Admin";
            await _repository.CreateAsync(admin);
            await _repository.SaveChangesAsync();
            return _mapper.Map<UserDTO>(admin);
        }
    }
}
