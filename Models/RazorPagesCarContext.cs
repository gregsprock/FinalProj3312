using Microsoft.EntityFrameworkCore;

namespace RazorPagesCar.Models
{
    public class RazorPagesCarContext : DbContext
    {
        public RazorPagesCarContext (DbContextOptions<RazorPagesCarContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCar.Models.Car> Car { get; set; }
        public DbSet<RazorPagesCar.Models.Review> Review { get; set; }
    }
}