using AutoMapper;
using Carental.BusinessLogic.Models;
using Carental.BusinessLogic.Services.Interfaces;
using Carental.DataAccess;
using Carental.DataAccess.Entities;
using Carental.DataAccess.Repositories.Interfaces;

namespace Carental.BusinessLogic.Services
{
    public class RenterService : IRenterService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRenterRepository _renterRepository;
        public RenterService(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IRenterRepository renterRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _renterRepository = renterRepository;
        }

        public IEnumerable<RenterModel> GetAll()
        {
            var renters = _renterRepository.GetAll();
            return _mapper.Map<IEnumerable<RenterModel>>(renters);
        }

        public RenterModel GetById(Guid id)
        {
            var renter = _renterRepository.GetById(id);
            return _mapper.Map<RenterModel>(renter);
        }

        public void Add(RenterModel renterModel)
        {
            var renter = _mapper.Map<Renter>(renterModel);
            _renterRepository.Add(renter);
            _unitOfWork.Save();
        }

        public void Update(Guid id, RenterModel renterModel)
        {
            var renter = _mapper.Map<Renter>(renterModel);
            renter.Id = id;
            _renterRepository.Update(renter);
            _unitOfWork.Save();
        }
    }
}
