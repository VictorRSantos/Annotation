using Annotation.Application.Commands.CreateDataAnnotation;
using Annotation.Core.Repositories;
using Annotation.Infrastructure.Persistence;
using Annotation.Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AnnotationDbContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("ConnectionSqlite")));

builder.Services.AddScoped<IDataAnnotationRepository, DataAnnotationRepository>();

builder.Services.AddMediatR(typeof(CreateDataAnnotationCommand));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
