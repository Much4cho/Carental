using Carental.BusinessLogic.Models;
using Carental.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Carental.WebApi.Controllers.Renters
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentersController : ControllerBase
    {
        private readonly ILogger<RentersController> _logger;
        private readonly IRenterService _renterService;

        public RentersController(
            ILogger<RentersController> logger,
            IRenterService renterService)
        {
            _logger = logger;
            _renterService = renterService;
        }

        [HttpGet]
        public IEnumerable<RenterModel> GetAll()
        {
            return _renterService.GetAll();
        }

        [HttpPost]
        public void Add(RenterModel renter)
        {
            _renterService.Add(renter);
        }
    }
}
