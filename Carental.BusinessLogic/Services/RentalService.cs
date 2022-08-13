using AutoMapper;
using Carental.BusinessLogic.Services.Interfaces;
using Carental.DataAccess.Repositories.Interfaces;
using Carental.DataAccess;
using Carental.BusinessLogic.Models.Rental;
using Carental.DataAccess.Entities;

namespace Carental.BusinessLogic.Services
{
    public class RentalService : IRentalService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRentalRepository _rentalRepository;
        public RentalService(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IRentalRepository rentalRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _rentalRepository = rentalRepository;
        }

        public IEnumerable<RentalModel> GetAll()
        {
            var rentals = _rentalRepository.GetAll();
            return _mapper.Map<IEnumerable<RentalModel>>(rentals);
        }

        public void StartRental(StartRentalCommand command)
        {
            var newRental = new Rental
            {
                CarId = command.CarId,
                Remarks = command.Remarks,
                RentedOnUtc = DateTime.UtcNow,
            };

            _rentalRepository.Add(newRental);
            _unitOfWork.Save();
        }
    }
}
