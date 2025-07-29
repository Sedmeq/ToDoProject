using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsersApp.Models;

namespace UsersApp.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);

                // TodoItem və User arasında relationship
                builder.Entity<ToDo>()
                    .HasOne(t => t.User)
                    .WithMany()
                    .HasForeignKey(t => t.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}