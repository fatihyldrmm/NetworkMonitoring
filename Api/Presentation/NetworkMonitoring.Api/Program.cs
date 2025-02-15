using Microsoft.EntityFrameworkCore;
using NetworkMonitoring.Persistence.Context;
using NetworkMonitoring.Persistence.Extensions;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        policy =>
        {
            policy.WithOrigins("https://localhost:7037")  // Blazor uygulamanızın URL'si
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowCredentials(); // Eğer kimlik doğrulama/çerezler ile çalışıyorsanız
        });
});
// Add services to the container.
builder.Services.AddDbContext<NetworkMonitoringContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("AllowSpecificOrigin");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
