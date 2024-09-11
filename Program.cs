using Jukebox.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Services.AddHttpClient<ISpotifyService, SpotifyService>(client =>
{
    client.BaseAddress = new Uri("https://api.spotify.com/");
});

builder.Services.AddScoped<ISpotifyService, SpotifyService>();
builder.Services.AddScoped<ISpotifyTokenService, SpotifyTokenService>();

// builder.Services.AddAutoMapper(typeof(MappingProfile)); //AutoMapper

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHttpsRedirection();
}

// public void ConfigureServices(IServiceCollection services)
// {
//     services.AddAutoMapper(typeof(MappingProfile));

//     // using AutoMapper? 

//     services.AddScoped<IUserService, UserService>();
//     services.AddScoped<IUserRepository, UserRepository>(); 

// }

app.MapControllers();

app.Run();