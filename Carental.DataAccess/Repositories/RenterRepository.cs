using Carental.DataAccess.Entities;
using Carental.DataAccess.Repositories.Interfaces;

namespace Carental.DataAccess.Repositories
{
    public class RenterRepository : RepositoryBase<Renter>, IRepositoryBase<Renter>
    {
        public RenterRepository(CarentalContext carentalContext) : base(carentalContext)
        {
        }
    }
}
