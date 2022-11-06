using Carental.DataAccess.Entities;

namespace Carental.DataAccess
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CS8604:Possible null reference argument", Justification = "Not production code.")]
    public class DataSeeder
    {
        private readonly CarentalContext _context;

        public DataSeeder(CarentalContext context) => _context = context;
        
        public void Seed()
        {
            _context.Database.EnsureCreated();
            if (_context.Renters?.Any() ?? true) return;

            var renters = new List<Renter>
            {
                new Renter
                {
                    Id = Guid.NewGuid(),
                    Name = "Panki"
                },
                new Renter
                {
                    Id = Guid.NewGuid(),
                    Name = "Gocar"
                },
            };

            var cars = new List<Car>
            {
                new Car
                {
                    Manufacturer = "Toyota",
                    Model = "Yaris",
                    PlateNumber = "KR12345",
                    Color = "Red",
                    PricePerMinute = 0.15m,
                    PricePerKilometer = 1.29m,
                    ParkedPricePerMinute = .10m,
                    RenterId = renters[0].Id,
                    Location = new Location
                    {
                        Latitude = 50.076817091348104m,
                        Longitude = 19.927420077832387m
                    }
                },
                new Car
                {
                    Manufacturer = "Toyota",
                    Model = "i20",
                    PlateNumber = "KR5943",
                    Color = "Green",
                    PricePerMinute = 0.15m,
                    PricePerKilometer = 1.29m,
                    ParkedPricePerMinute = .10m,
                    RenterId = renters[0].Id,
                    Location = new Location
                    {
                        Latitude = 50.06927255958391m,
                        Longitude = 19.93786556055238m
                    }
                },
                new Car
                {
                    Manufacturer = "Toyota",
                    Model = "Yaris",
                    PlateNumber = "KR5924",
                    Color = "Red",
                    PricePerMinute = 0.15m,
                    PricePerKilometer = 1.29m,
                    ParkedPricePerMinute = .10m,
                    RenterId = renters[1].Id,
                    Location = new Location
                    {
                        Latitude = 50.05430914618797m,
                        Longitude = 19.935709604938097m
                    }
                },
            };

            _context.AddRange(renters);
            _context.AddRange(cars);
            _context.SaveChanges();
        }
    }
}
