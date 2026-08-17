using Asp.Versioning;
using Assignment_4.Middleware;
using Assignment_4.Repository;
using Assignment_4.services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<ITaskService, TaskService>();

builder.Services.AddSingleton<ITaskRepository,  TaskRepository>();

builder.Services.AddApiVersioning(option =>
{
    option.DefaultApiVersion = new ApiVersion(1, 0);
    option.AssumeDefaultVersionWhenUnspecified = true;
    option.ReportApiVersions = true;
}).AddApiExplorer(option => {
    option.GroupNameFormat = "'v'VVV";
    option.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseMiddleware<SunSet>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
