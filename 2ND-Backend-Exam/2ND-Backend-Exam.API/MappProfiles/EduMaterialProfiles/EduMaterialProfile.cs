namespace _2ND_Backend_Exam.API.MappProfiles.EduMaterialProfiles
{
    public class EduMaterialProfile : Profile
    {
        public EduMaterialProfile()
        {
            CreateMap<EduMaterial, EduMaterialDTO>()
                .ReverseMap();
            CreateMap<EduMaterialPutDTO, EduMaterial>()
                .ReverseMap();
            CreateMap<EduMaterialPostDTO, EduMaterial>()
                .ReverseMap();
        }
    }
}
