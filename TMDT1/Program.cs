using Microsoft.EntityFrameworkCore;
using TMDT1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SHOPDBContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("Shopconnection") ?? throw new InvalidOperationException("Connection string 'SHOPDBContext' not found.")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
var supportedCultures = new[] { "en-US", "vi-VN" };
var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture("en-US")
                                                           .AddSupportedCultures(supportedCultures)
                                                           .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
