using Carental.DataAccess.Entities;
using Carental.DataAccess.Repositories.Interfaces;

namespace Carental.DataAccess.Repositories
{
    public class RenterRepository : GenericRepository<Renter>, IGenericRepository<Renter>
    {
        public RenterRepository(CarentalContext carentalContext) : base(carentalContext)
        {
        }
    }
}
