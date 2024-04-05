using Microsoft.EntityFrameworkCore;

namespace DatabaseApi.Models
{
    public class DataBaseContextModel : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


			modelBuilder.Entity<Person>()
           .HasOne(p => p.Nationality).WithOne(n=>n.Person);

            new DbInitializer(modelBuilder).Seed();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;database=interview;User=root1;Password=1234;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

    }
}
