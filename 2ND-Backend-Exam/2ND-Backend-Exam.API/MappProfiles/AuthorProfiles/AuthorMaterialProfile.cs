namespace _2ND_Backend_Exam.API.MappProfiles.AuthorProfiles
{
    public class AuthorMaterialProfile : Profile
    {
        public AuthorMaterialProfile()
        {
            CreateMap<EduMaterial, AuthorMaterialDTO>()
                .ReverseMap();
        }
    }
}
