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

        public DbSet<Car>? Cars { get; set; }
        public DbSet<Rental>? Rentals { get; set; }
        public DbSet<Renter>? Renters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var car = modelBuilder.Entity<Car>();
            car.Property(e => e.Id).HasDefaultValueSql("newsequentialid()");
            car.Property(e => e.Manufacturer).IsRequired();
            car.Property(e => e.Model).IsRequired();
            car.Property(e => e.Color).IsRequired();
            car.Property(e => e.PlateNumber).IsRequired();
            car.Property(e => e.PricePerMinute).HasPrecision(18, 2);
            car.Property(e => e.PricePerKilometer).HasPrecision(18, 2);
            car.Property(e => e.ParkedPricePerMinute).HasPrecision(18, 2);

            var rental = modelBuilder.Entity<Rental>();
            rental.Property(e => e.Id).HasDefaultValueSql("newsequentialid()");
            rental.Property(e => e.TotalPrice).HasPrecision(18, 2);

            var renter = modelBuilder.Entity<Renter>();
            renter.Property(e => e.Id).HasDefaultValueSql("newsequentialid()");
            renter.Property(e => e.Name).IsRequired();

        }
    }
}
