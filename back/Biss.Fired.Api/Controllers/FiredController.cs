using Microsoft.AspNetCore.Mvc;
using Biss.Fired.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace Biss.Fired.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FiredController : ControllerBase
    {
        private readonly ILogger<FiredController> _logger;
        private AppDbContext _dbContext = new AppDbContext();
        public FiredController(ILogger<FiredController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models.Fired>>> GetFired()
        {
            var entities = await _dbContext.Fired.ToListAsync();
            if (entities != null)
                return Ok(entities);           

            return NoContent();
            
        }
        [HttpGet("{name}")]
        public async Task<ActionResult<Models.Fired>> GetFiredByName(string name)
        {
            var entity = await _dbContext.Fired.FirstOrDefaultAsync(f => f.Name== name);
            if (entity != null)
                return Ok(entity);

            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Models.Fired>> PostFired(Models.Fired fired)
        {
            if (fired == null)
            {
                BadRequestObjectResult badRequest = new BadRequestObjectResult("Demitido esta Vazio");
                return badRequest;
            }
            if (string.IsNullOrEmpty(fired.Name))
            {
                BadRequestObjectResult badRequest = new BadRequestObjectResult("Nome é obrigatório.");
                return badRequest;
            }
            OkObjectResult result = new OkObjectResult(fired);
            return result;
        }

        [HttpPut]
        public async Task<ActionResult<Models.Fired>> PutFired(Models.Fired fired)
        {
            OkObjectResult result = new OkObjectResult(fired);
            return result;
        }
    }
}