using DatabaseApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataBaseContextModel>();
var app = builder.Build();

app.MapControllers();

app.Run();
