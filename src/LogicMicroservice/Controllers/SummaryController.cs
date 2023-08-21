using LogicMicroservice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogicMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryController : ControllerBase
    {
        private readonly ISummaryService _summaryService;
        private readonly ILogger<SummaryController> _logger;
        public SummaryController(ISummaryService summaryService, ILogger<SummaryController> logger)
        {
            _summaryService = summaryService;
            _logger = logger;
        }
        [HttpPost("calculate")]
        public async Task<IActionResult> CalculateSecondOddSummary([FromBody] int[] digits)
        {
           
            var summary = _summaryService.CalculateSecondOdd(digits);

            return Ok(summary);

        }

    }
}
