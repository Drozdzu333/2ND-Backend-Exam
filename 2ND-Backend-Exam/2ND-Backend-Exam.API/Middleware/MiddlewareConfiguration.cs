namespace _2ND_Backend_Exam.API.Middleware
{
    public static class MiddlewareConfiguration
    {
        public static void AddCustomMiddlewareConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ErrorHandlingMiddleware>();
            services.AddScoped<LoggingMiddleware>();
        }

    }
}
