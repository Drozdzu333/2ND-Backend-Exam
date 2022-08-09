namespace _2ND_Backend_Exam.API.MappProfiles.EduMaterialProfiles
{
    public class EduMaterialProfile : Profile
    {
        public EduMaterialProfile()
        {
            CreateMap<EduMaterial, EduMaterialDTO>()
                .ForMember(dest => dest.Author,
                opt => opt.MapFrom(src => src.Author.ToString()))
                .ForMember(dest => dest.MaterialType,
                opt => opt.MapFrom(src => src.MaterialType.ToString()))
                .ReverseMap();
            CreateMap<EduMaterialPutDTO, EduMaterial>()
                .ReverseMap();
            CreateMap<EduMaterialPostDTO, EduMaterial>()
                .ReverseMap();
        }
    }
}
