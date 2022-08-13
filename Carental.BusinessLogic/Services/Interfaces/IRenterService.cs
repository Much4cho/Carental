using Carental.BusinessLogic.Models;

namespace Carental.BusinessLogic.Services.Interfaces
{
    public interface IRenterService
    {
        IEnumerable<RenterModel> GetAll();
        RenterModel GetById(Guid id);
        void Add(RenterModel renterModel);
        void Update(Guid id, RenterModel renter);
    }
}