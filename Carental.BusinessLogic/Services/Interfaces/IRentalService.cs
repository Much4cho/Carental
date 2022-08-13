using Carental.BusinessLogic.Models.Rental;

namespace Carental.BusinessLogic.Services.Interfaces
{
    public interface IRentalService
    {
        IEnumerable<RentalModel> GetAll();
        void StartRental(StartRentalCommand command);
    }
}