using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ReviewDbContext : DbContext
    {

        public DbSet<Review> reviews { get; set; }

        public ReviewDbContext() { }

        public ReviewDbContext(DbContextOptions<ReviewDbContext> options)
        :base(options){ }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            
        }

    }
}
