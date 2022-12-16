using AspTest.AnimalDb.Tables;
using Microsoft.EntityFrameworkCore;

namespace AspTest.AnimalDb
{
    public class AnimalDbContext: DbContext
    {
        public DbSet<Animal> Students { get; set; }
        public DbSet<Food> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;Trust Server Certificate=true;");
        }
    }
}
