namespace _2ND_Backend_Exam.API.appConfig
{
    public class AuthenticationConfig
    {
        private readonly IServiceCollection _services;
        private readonly IConfiguration _configuration;
        public AuthenticationConfig(IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            _services = serviceDescriptors;
            _configuration = configuration;
        }
        public void AddAuthenticationSome()
        {
            var jwtKey = _configuration["JWT:Key"];
            var jwtAudience = _configuration["JWT:Issuer"];
            var jwtIssuer = _configuration["JWT:Audience"];

            _services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = jwtAudience,
                        ValidIssuer = jwtIssuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
                    };
                });
        }
    }
}
