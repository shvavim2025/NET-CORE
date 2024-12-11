using Coins.Api;
using Coins.Core.InterfaceRepository;
using Coins.Data;
using Coins.Data.Repository;
using Coins.Service;

var builder = WebApplication.CreateBuilder(args);

string r = "eeee";
r.ServiceScope();
//builder.Services.ServiceScope();
// Add services to the container.
builder.Services.ServieDependencyInjector();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
