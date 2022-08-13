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

            var car = modelBuilder.Entity<Car>();
            car.Property(e => e.RenterId).IsRequired();
            car.Property(e => e.PricePerMinute).HasPrecision(18, 2);
            car.Property(e => e.PricePerKilometer).HasPrecision(18, 2);
            car.Property(e => e.ParkedPricePerMinute).HasPrecision(18, 2);

            var renter = modelBuilder.Entity<Renter>();
            renter.Property(e => e.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
