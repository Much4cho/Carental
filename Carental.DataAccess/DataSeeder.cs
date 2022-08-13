using Carental.DataAccess.Entities;

namespace Carental.DataAccess
{
    public class DataSeeder
    {
        private readonly CarentalContext _context;

        public DataSeeder(CarentalContext context) => _context = context;
        
        public void Seed()
        {
            _context.Database.EnsureCreated();
            if (_context.Renters.Any()) return;

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
                    Name = "Test"
                },
            };

            _context.AddRange(renters);
            _context.SaveChanges();
        }
    }
}
