using AutoMapper;
using Carental.BusinessLogic.Models;
using Carental.BusinessLogic.Services.Interfaces;
using Carental.DataAccess.Repositories.Interfaces;
using Carental.DataAccess;
using Carental.DataAccess.Entities;

namespace Carental.BusinessLogic.Services
{
    public class CarService : ICarService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICarRepository _carRepository;
        public CarService(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ICarRepository carRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _carRepository = carRepository;
        }
        public IEnumerable<CarModel> GetAll()
        {
            var cars = _carRepository.GetAll();
            return _mapper.Map<IEnumerable<CarModel>>(cars);
        }
        public CarModel GetById(Guid id)
        {
            var car = _carRepository.GetById(id);
            return _mapper.Map<CarModel>(car);
        }
        public void Add(CarModel carModel)
        {
            var car = _mapper.Map<Car>(carModel);
            _carRepository.Add(car);
            _unitOfWork.Save();
        }

        public void Update(Guid id, CarModel carModel)
        {
            var car = _mapper.Map<Car>(carModel);
            car.Id = id;
            _carRepository.Update(car);
            _unitOfWork.Save();
        }
    }
}
