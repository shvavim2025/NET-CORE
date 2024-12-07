using CoinsViritual.Data;
using CoinsViritual.Data.Repository;
using CoinsViritual.Service;
using CoinsViritul.Core.IRepository;
using CoinsViritul.Core.IService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICoinsService, CoinsService>();
builder.Services.AddScoped<ICoinsRepository, CoinsRepository>();
builder.Services.AddSingleton
    <DataContext>();
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
