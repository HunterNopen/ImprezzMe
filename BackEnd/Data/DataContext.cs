using BackEnd.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<ChatMessages> ChatMessages { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<User>()
                .HasOne(u => u.City)
                .WithMany(c => c.Users);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.City);

            modelBuilder.Entity<Token>()
                .HasOne(e => e.User);

            modelBuilder.Entity<Chat>()
                .HasOne(e => e.Event)
                .WithOne();
        }
    }
}
