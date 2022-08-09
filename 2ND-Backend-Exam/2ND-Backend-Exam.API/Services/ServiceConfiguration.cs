namespace _2ND_Backend_Exam.API.Services
{
    public static class ServiceConfiguration
    {
        public static void AddCustomServicesAndRepositories(this IServiceCollection service)
        {
            // Repositories
            service.AddTransient<IUserRepository, UserRepository>();
            service.AddScoped<IAuthorRepository, AuthorRepository>();
            service.AddScoped<IMaterialTypeRepository, MaterialTypeRepository>();
            service.AddScoped<IEduMaterialRepository, EduMaterialRepository>();
            service.AddScoped<IReviewRepository, ReviewRepository>();

            //Services
            service.AddScoped<IAuthorService, AuthorServicecs>();
            service.AddScoped<IMaterialTypeService, MaterialTypeService>();
            service.AddScoped<IEduMaterialService, EduMaterialService>();
            service.AddScoped<IReviewService, ReviewService>();
        }
    }
}
