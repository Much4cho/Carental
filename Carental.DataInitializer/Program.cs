using Carental.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Carental.DataInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contextOptions = new DbContextOptionsBuilder<CarentalContext>()
            .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=Carental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            .Options;

            var _context = new CarentalContext(contextOptions);
            new DataSeeder(_context).Seed();

            Console.WriteLine("Done");
        }
    }
}