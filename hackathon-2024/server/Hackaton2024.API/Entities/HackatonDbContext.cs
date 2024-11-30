using Microsoft.EntityFrameworkCore;

namespace Hackaton2024.API.Entities
{
    public class HackatonDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public HackatonDbContext(DbContextOptions<HackatonDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(p => p.Activities)
                .WithOne(x => x.User);
        }
    }
}
