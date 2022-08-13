using Carental.BusinessLogic.Models.Rental;
using Carental.BusinessLogic.Services.Interfaces;
using Carental.WebApi.Controllers.Cars;
using Microsoft.AspNetCore.Mvc;

namespace Carental.WebApi.Controllers.Rentals
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        private readonly IRentalService _rentalService;

        public RentalsController(
            ILogger<CarsController> logger,
            IRentalService rentalService)
        {
            _logger = logger;
            _rentalService = rentalService;
        }

        [HttpGet]
        public IEnumerable<RentalModel> GetAll()
        {
            return _rentalService.GetAll();
        }


        [HttpPost("StartRental")]
        public void Rent([FromBody] StartRentalCommand command)
        {
            _rentalService.StartRental(command);
        }
    }
}
