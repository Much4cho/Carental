using Carental.BusinessLogic.Models;
using Carental.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Carental.WebApi.Controllers.Cars
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        private readonly ICarService _carService;

        public CarsController(
            ILogger<CarsController> logger,
            ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }

        [HttpGet]
        public IEnumerable<CarModel> GetAll()
        {
            return _carService.GetAll();
        }

        [HttpPost]
        public void Add(CarModel car)
        {
            _carService.Add(car);
        }
    }
}
