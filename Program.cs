using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Interfaces;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Persistence;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Services;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
var connectonString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectonString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IRespuestaService, RespuestaServices>();
builder.Services.AddScoped<IPreguntasServices, PreguntasServices>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
