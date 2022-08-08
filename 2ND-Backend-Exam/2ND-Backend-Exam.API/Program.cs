var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ErrorHandlingMiddleware>();
builder.Services.AddScoped<LoggingMiddleware>();
// Data Base
var connectionString = builder.Configuration.GetConnectionString("EduDataBase");
builder.Services.AddDbContext<EduContext>(options => options.UseSqlServer(connectionString));

// Scooped
builder.Services.AddScoped<IAuthorService, AuthorServicecs>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
