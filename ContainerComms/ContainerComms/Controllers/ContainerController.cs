using Microsoft.AspNetCore.Mvc;
using ContainerComms.Data;
using System.Linq;

namespace ContainerComms.Controllers
{
    public class ContainerController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ContainerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("api/container")]
        public IActionResult Get()
        {
            return Ok(_dbContext.Containers.ToList());
        }
    }
}
