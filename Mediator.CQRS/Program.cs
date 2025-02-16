using FluentValidation;
using Mediator.CQRS.Extentions;
using Mediator.CQRS.Interfaces;
using Mediator.CQRS.Pipelines;
using Mediator.CQRS.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddMediatR(options => options.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddTransient(typeof(IPipelineBehavior<,>) , typeof(RequestPipeline<,>));

builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.HandleException();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
