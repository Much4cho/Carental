using Carental.BusinessLogic.Models;

namespace Carental.BusinessLogic.Services.Interfaces
{
    public interface IRenterService
    {
        IEnumerable<RenterModel> GetAll();
        void Add(RenterModel renterModel);
    }
}