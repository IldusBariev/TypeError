using Microsoft.EntityFrameworkCore;
using APIshka.Entities;


namespace APIshka.DbContexts
{

    public class AppDbContext : DbContext
    {

    public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;username=root;password=12032003;database=apishechka",
                new MySqlServerVersion(new Version(8, 0, 40)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.HasKey(u => u.UserId);
            });
        }

    }
}
