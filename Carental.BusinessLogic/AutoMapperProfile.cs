using AutoMapper;
using Carental.BusinessLogic.Models;
using Carental.DataAccess.Entities;

namespace Carental.BusinessLogic
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Car, CarModel>().ReverseMap();
            CreateMap<Renter, RenterModel>().ReverseMap();
        }
    }
}
