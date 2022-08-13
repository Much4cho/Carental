using Carental.DataAccess.Entities;
using Carental.DataAccess.Repositories.Interfaces;

namespace Carental.DataAccess.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(CarentalContext carentalContext) : base(carentalContext)
        {
        }
    }
}
