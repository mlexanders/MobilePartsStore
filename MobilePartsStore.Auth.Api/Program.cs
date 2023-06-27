using CRUD.Actions.Implementation;
using Microsoft.EntityFrameworkCore;
using MobileParts.Common.Models;
using MobilePartsStore.Auth.Api;
using MobilePartsStore.Auth.Api.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AuthDbContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("MobilePartsAuthDb"));
});

//builder.Services.AddTransient(s => new BaseCrudRepository<Account, Guid>(s.GetRequiredService<AuthDbContext>())); 
builder.Services.AddTransient(s => new AccountRepository(s.GetRequiredService<AuthDbContext>()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
