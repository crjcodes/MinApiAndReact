using LabAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("mockdata.json");

// Add services to the container.

builder.Services.AddOptions();
builder.Services.Configure<List<FlattenedLabRecord>>(
    builder.Configuration.GetSection("LabRecords"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
