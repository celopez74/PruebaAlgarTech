using Microsoft.Extensions.Configuration;
using System;
using TestAlgarBlazor.BusinessLogic.ApplicationServices;
using TestAlgarBlazor.Infrastructure.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfraestructure(builder.Configuration);
//builder.Services.Configure<PurchaseApplicationService>(builder.Configuration);
builder.Services.AddSingleton<IPurchaseApplicationService, PurchaseApplicationService>();


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
