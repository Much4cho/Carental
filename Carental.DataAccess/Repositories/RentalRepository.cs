using Carental.DataAccess.Entities;
using Carental.DataAccess.Repositories.Interfaces;

namespace Carental.DataAccess.Repositories
{
    public class RentalRepository : GenericRepository<Rental>, IRentalRepository
    {
        public RentalRepository(CarentalContext carentalContext) : base(carentalContext)
        {
        }
    }
}
