using IssueTrackerLite.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTrackerLite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Issue> Issues => Set<Issue>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Issue>()
                   .HasIndex(i => new { i.Status, i.Priority });

            builder.Entity<Issue>()
                   .Property(i => i.CreatedAt)
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
