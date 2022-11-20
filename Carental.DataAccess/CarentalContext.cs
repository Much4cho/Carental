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
        //public DbSet<User>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Owned<Location>();

            modelBuilder.Entity<Car>(car =>
            {
                car.Property(e => e.Id).HasDefaultValueSql("newsequentialid()");
                car.Property(e => e.Manufacturer).IsRequired();
                car.Property(e => e.Model).IsRequired();
                car.Property(e => e.Color).IsRequired();
                car.Property(e => e.PlateNumber).IsRequired();
                car.OwnsOne(e => e.Location,
                    car =>
                    {
                        car.Property(e => e.Latitude).HasPrecision(18, 15);
                        car.Property(e => e.Longitude).HasPrecision(18, 15);
                    });
            });


            modelBuilder.Entity<Rental>(rental =>
            {
                rental.Property(e => e.Id).HasDefaultValueSql("newsequentialid()");
                rental.OwnsOne(e => e.LastLocation,
                    rental =>
                    {
                        rental.Property(e => e.Latitude).HasPrecision(18, 15);
                        rental.Property(e => e.Longitude).HasPrecision(18, 15);
                    });
            });
            

            modelBuilder.Entity<Renter>(renter =>
            {
                renter.Property(e => e.Id).HasDefaultValueSql("newsequentialid()");
                renter.Property(e => e.Name).IsRequired();
            });

            //modelBuilder.Entity<User>(user =>
            //{
            //    user.Property(e => e.Id).HasDefaultValueSql("newsequentialid()");
            //    user.Property(e => e.Name).IsRequired();
            //});
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<decimal>().HavePrecision(18, 2);
        }
    }
}
