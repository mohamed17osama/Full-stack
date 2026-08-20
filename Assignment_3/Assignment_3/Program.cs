using Assignment_3.Exceptions;
using Assignment_3.Interfaces;
using Assignment_3.Repositories;
using Assignment_3.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITaskService, TaskService>();
builder.Services.AddSingleton<ITaskRepository, TaskRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

app.UseMiddleware<GlobalException>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
