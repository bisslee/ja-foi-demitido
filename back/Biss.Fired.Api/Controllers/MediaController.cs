using Biss.Fired.Api.Data;
using Biss.Fired.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biss.Fired.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediaController : ControllerBase
    {
        private readonly ILogger<MediaController> _logger;
        private AppDbContext _dbContext = new AppDbContext();
        public MediaController(ILogger<MediaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Media>>> GetMedia(int id)        
        {
            var entities = await _dbContext.Media.Where(m => m.Fired.Id == id).ToListAsync();
            if (entities != null)
                return Ok(entities);

            return NoContent();

        }
        [HttpPost]
        public async Task<ActionResult<List<string>>> PostMedia(string name)
        {

            OkObjectResult result = new OkObjectResult(name);
            return result;
        }
    }
}