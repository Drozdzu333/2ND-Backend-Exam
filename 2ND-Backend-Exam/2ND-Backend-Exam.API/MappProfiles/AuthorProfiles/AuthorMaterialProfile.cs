namespace _2ND_Backend_Exam.API.MappProfiles.AuthorProfiles
{
    public class AuthorMaterialProfile : Profile
    {
        public AuthorMaterialProfile()
        {
            CreateMap<EduMaterial, AuthorMaterialDTO>()
           .ForMember(dest => dest.PublicationDate,
            opt => opt.MapFrom(src => DateOnly.FromDateTime(src.PublicationDate).ToString()))
                .ReverseMap();
        }
    }
}
