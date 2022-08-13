using Carental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carental.DataAccess
{
    public class CarentalContext : DbContext
    {
        public CarentalContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Renter>? Renters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
