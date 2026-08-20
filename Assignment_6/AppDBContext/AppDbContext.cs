using Assignment_6.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_6.AppDBContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<TaskItem> TaskItems { get; set; }

        public AppDbContext(DbContextOptions options)  : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Name).IsRequired().HasMaxLength(200);
                entity.Property(t => t.Age);

            });

            modelBuilder.Entity<TaskItem>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Title).IsRequired().HasMaxLength(200);
                entity.Property(t => t.IsCompleted).IsRequired();
                entity.HasOne(t => t.User).WithMany(u => u.TaskItem).HasForeignKey(t => t.UserId).OnDelete(DeleteBehavior.Cascade);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
