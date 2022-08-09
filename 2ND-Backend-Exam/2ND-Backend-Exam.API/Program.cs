using _2ND_Backend_Exam.API.appConfig;

var builder = WebApplication.CreateBuilder(args);

var authentication = new AuthenticationConfig(builder.Services, builder.Configuration);
authentication.AddAuthenticationSome();

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(build =>
    {
        build.AllowAnyOrigin();
    });
});


// Data Base
var connectionStringEduDB = builder.Configuration["ConnectionStrings:EduDataBase"];
builder.Services.AddDbContext<EduContext>(options => options.UseSqlServer(connectionStringEduDB));

// Services and Repositories
builder.Services.AddCustomServicesAndRepositories();

// Swagger with auth
builder.Services.AddSwaggerCustomConfig();

// Middleware services
builder.Services.AddCustomMiddlewareConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
