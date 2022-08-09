namespace _2ND_Backend_Exam.API.MappProfiles.UserProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserPostDTO, User>()
                .ReverseMap();
            CreateMap<User, UserDTO>()
                .ReverseMap();
        }
    }
}
