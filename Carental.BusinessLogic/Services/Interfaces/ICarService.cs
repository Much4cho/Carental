using Carental.BusinessLogic.Models;

namespace Carental.BusinessLogic.Services.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetAll();
        CarModel GetById(Guid id);
        void Add(CarModel renterModel);
        void Update(Guid id, CarModel car);
    }
}