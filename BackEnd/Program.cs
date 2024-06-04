using BackEnd.Data;
using BackEnd.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DataContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 23))));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Environment.EnvironmentName = "Development";
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();
            //app.UseAuthentication();
            //app.UseAuthorization();

            app.MapGet("/", () => "Hello World!");

            app.MapPost("/userCreate", async (User user, DataContext db) =>
            {
                db.Add(user);
                db.SaveChanges();
                return user;
            });

            app.Run();
        }
    }
}
