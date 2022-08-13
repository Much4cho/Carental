using Carental.BusinessLogic.Models;
using Carental.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Carental.WebApi.Controllers.Renter
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenterController : ControllerBase
    {
        private readonly ILogger<RenterController> _logger;
        private readonly IRenterService _renterService;

        public RenterController(
            ILogger<RenterController> logger,
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
