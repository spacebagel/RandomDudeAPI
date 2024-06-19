using RandomDudeAPI.Data;
using RandomDudeAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ConnectionString");

builder.Services.AddSqlServer<PersonContext>(connectionString);

builder.Services.AddScoped<CityService>();
builder.Services.AddScoped<CountryService>();
builder.Services.AddScoped<PersonService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();