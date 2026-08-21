using Microsoft.EntityFrameworkCore;
using Task_1.Models;

namespace Task_1.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        
        public AppDbContext(DbContextOptions options):base(options)  { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Title).IsRequired().HasMaxLength(50);
                //entity.Property(t => t.IsCompleted).HasComputedColumnSql("CAST(CASE WHEN [Status] = 'Done' THEN 1 ELSE 0 END AS BIT)", stored : true);
                entity.Property(t => t.Status).IsRequired().HasMaxLength(50);
                entity.Property(t => t.CreatedAt).HasDefaultValueSql("GETDATE()");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
