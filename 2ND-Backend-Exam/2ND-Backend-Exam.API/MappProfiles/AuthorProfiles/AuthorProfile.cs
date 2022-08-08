namespace _2ND_Backend_Exam.API.MappProfiles.AuthorProfiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDTO>()
                .ReverseMap();
            CreateMap<AuthorPutDTO, Author>()
                 .ReverseMap();
            CreateMap<AuthorPostDTO, Author>()
                 .ReverseMap();
        }
    }
}
