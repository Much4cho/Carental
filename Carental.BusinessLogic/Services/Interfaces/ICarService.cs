using Carental.BusinessLogic.Models;

namespace Carental.BusinessLogic.Services.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetAll();
        void Add(CarModel renterModel);
    }
}