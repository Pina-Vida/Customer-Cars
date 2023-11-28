using Microsoft.AspNetCore.Mvc;

namespace SampleSolution.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {     
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public IEnumerable<bool> Get()
        {
            return (IEnumerable<bool>)Ok(true);
        }
    }
}
