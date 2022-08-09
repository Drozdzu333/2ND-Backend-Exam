namespace _2ND_Backend_Exam.API.MappProfiles.ReviewProfiles
{
    public class ReviewMaterialProfile : Profile
    {
        public ReviewMaterialProfile()
        {
            CreateMap<EduMaterial, ReviewEduMaterialDTO>();
        }
    }
}
