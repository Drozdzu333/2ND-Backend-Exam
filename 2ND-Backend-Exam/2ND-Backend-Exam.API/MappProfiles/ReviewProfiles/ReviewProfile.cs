namespace _2ND_Backend_Exam.API.MappProfiles.ReviewProfiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewDTO>()
                .ReverseMap();

            CreateMap<ReviewPutDTO, Review>()
                .ReverseMap();
        }
    }
}
