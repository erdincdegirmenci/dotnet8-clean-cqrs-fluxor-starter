using CQRS.Project.HttpClients;
using CQRS.Project.HttpClients.Interfaces;
using CQRS.Project.Services;
using CQRS.Project.Services.Interfaces;
using Fluxor;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddHttpClient<IMediumHttpClient, MediumHttpClient>(client =>
{
    client.BaseAddress = new Uri("https://localhost:5202");
});

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining<Program>();
});

builder.Services.AddFluxor(options =>options.ScanAssemblies(typeof(Program).Assembly));

builder.Services.AddSingleton<IMediumService, MediumService>();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();


app.Run();
