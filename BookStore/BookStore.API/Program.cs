
using BookStore.Application.Services.Implementation;
using BookStore.Application.Services.Interfaces;
using BookStore.Domain.RepositoryInterfaces;
using BookStore.Infrastructure.Context;
using BookStore.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace BookStore.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ==================
            // Add services
            // ==================

            // Application Services
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IBookServices, BookServices>();
            // Controllers
            builder.Services.AddControllers();
            builder.Services.AddScoped<BookServices>();

            // Swagger (for testing API endpoints)
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "BookStore API",
                    Version = "v1",          // This sets the version in the Swagger JSON
                    Description = "API for managing books in BookStore"
                });
            });

            // Inside builder.Services configuration
            builder.Services.AddDbContext<BookStoreDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // ==================
            // Middleware pipeline
            // ==================
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore API v1");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}
