using AutoMapper;
using Carental.BusinessLogic.Models;
using Carental.BusinessLogic.Services.Interfaces;
using Carental.DataAccess.Entities;
using Carental.DataAccess.Repositories.Interfaces;

namespace Carental.BusinessLogic.Services
{
    public class RenterService : IRenterService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryBase<Renter> _renterRepository;
        public RenterService(
            IMapper mapper,
            IRepositoryBase<Renter> renterRepository)
        {
            _mapper = mapper;
            _renterRepository = renterRepository;
        }

        public IEnumerable<RenterModel> GetAll()
        {
            var renters = _renterRepository.GetAll();
            return _mapper.Map<IEnumerable<RenterModel>>(renters);
        }
    }
}
