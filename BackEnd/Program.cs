using BackEnd._Services.Interfaces;
using BackEnd.Data;
using BackEnd.Models.DTOs;
using BackEnd.Models.Entities;
using BackEnd.Models.Mappers;
using BackEnd.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<DataContext>(options =>
            options.UseMySql(connectionString,
            ServerVersion.AutoDetect(connectionString)));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IAuthService, AuthService>();
            InjectMappers(builder.Services);

            builder.Environment.EnvironmentName = "Development";
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }

        private static void InjectMappers(IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<IMap<UserDTO, User>, UserMapper>();

            serviceProvider.AddScoped<IMapper, Mapper>();
        }
    }
}
