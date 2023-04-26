using Microsoft.AspNetCore.Mvc;

namespace Biss.Fired.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FiredController : ControllerBase
    {
        private readonly ILogger<FiredController> _logger;

        public FiredController(ILogger<FiredController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<string>>> GetFired()
        {
            List<string> list = new List<string> { "azzul", "Amarelo", "verde" };
            OkObjectResult result = new OkObjectResult(list);
            return  result;
        }
        [HttpGet("{name}")]
        public async Task<ActionResult<List<string>>> GetFiredByName(string name)
        {
            
            OkObjectResult result = new OkObjectResult(name);
            return result;
        }
        [HttpPost]
        public async Task<ActionResult<List<string>>> PostFired(string name)
        {

            OkObjectResult result = new OkObjectResult(name);
            return result;
        }

        [HttpPut]
        public async Task<ActionResult<List<string>>> PutFired(string name)
        {

            OkObjectResult result = new OkObjectResult(name);
            return result;
        }
    }
}