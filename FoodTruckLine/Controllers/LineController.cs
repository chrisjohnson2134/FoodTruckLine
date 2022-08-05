using FoodTruckLine.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruckLine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LineController : ControllerBase
    {
        private readonly ILogger<LineController> _logger;

        List<LineMemberDto> a = new List<LineMemberDto>
        {
            new LineMemberDto(1,"Chris","11:00","8,1,2022"),
            new LineMemberDto(2,"Gary","11:00","8,1,2022"),
            new LineMemberDto(3,"Zach","11:00","8,1,2022"),
            new LineMemberDto(4,"Nick","11:30","8,1,2022"),
            new LineMemberDto(5,"Fido","11:30","8,1,2022"),
            new LineMemberDto(6,"Gus","11:30","8,1,2022"),
            new LineMemberDto(7,"Jerry","11:30","8,1,2022"),
            new LineMemberDto(8,"Lanyard","11:30","8,1,2022"),
        };

        public LineController(ILogger<LineController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LineMemberDto>>> Get()
        {
            return Ok(a);
        }

        [HttpGet("NowServing")]
        public async Task<ActionResult<IEnumerable<LineMemberDto>>> NowServingGet()
        {
            return Ok(a.Where(t => t.Id <= 4));
        }

        [HttpGet("CurrentWaiting")]
        public async Task<ActionResult<IEnumerable<LineMemberDto>>> CurrentWaitingGet()
        {
            return Ok(a.Where(t => t.Id > 4));
        }
    }
}
