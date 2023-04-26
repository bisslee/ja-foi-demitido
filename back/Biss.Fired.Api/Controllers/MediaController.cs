using Microsoft.AspNetCore.Mvc;

namespace Biss.Fired.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediaController : ControllerBase
    {
        private readonly ILogger<MediaController> _logger;

        public MediaController(ILogger<MediaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<string>>> GetMedia()
        {
            List<string> list = new List<string> { "azzul", "Amarelo", "verde" };
            OkObjectResult result = new OkObjectResult(list);
            return  result;
        }
       
        [HttpPost]
        public async Task<ActionResult<List<string>>> PostMedia(string name)
        {

            OkObjectResult result = new OkObjectResult(name);
            return result;
        }
    }
}