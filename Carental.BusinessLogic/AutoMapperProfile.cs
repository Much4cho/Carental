using AutoMapper;
using Carental.BusinessLogic.Models;
using Carental.BusinessLogic.Models.Rental;
using Carental.DataAccess.Entities;

namespace Carental.BusinessLogic
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Car, CarModel>().ReverseMap()
                .ForMember(x => x.Renter, y => y.Ignore());

            CreateMap<Rental, RentalModel>().ReverseMap()
                .ForMember(x => x.Car, y => y.Ignore());

            CreateMap<Renter, RenterModel>().ReverseMap()
                .ForMember(x => x.Cars, y => y.Ignore());
        }
    }
}
