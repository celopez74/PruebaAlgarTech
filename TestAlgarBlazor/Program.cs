using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TestAlgarBlazor.BusinessLogic.ApplicationServices;
using TestAlgarBlazor.Infrastructure.DataBase;


var builder = WebApplication.CreateBuilder(args);

ConfigurationManager _configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddInfraestructure(_configuration);
builder.Services.AddScoped<IProductApplicationService, ProductApplicationService>();
builder.Services.AddScoped<IPurchaseApplicationService, PurchaseApplicationService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

