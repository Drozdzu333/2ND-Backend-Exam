namespace _2ND_Backend_Exam.API.MappProfiles.MaterialTypeProfiles
{
    public class MaterialTypeProfile : Profile
    {
        public MaterialTypeProfile()
        {
            CreateMap<MaterialType, MaterialTypeDTO>()
                .ReverseMap();
            CreateMap<MaterialTypePutDTO, MaterialType>()
                .ReverseMap();
            CreateMap<MaterialTypePostDTO, MaterialType>()
                .ReverseMap();
        }
    }
}
