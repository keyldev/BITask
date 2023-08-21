using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ViewMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryController : ControllerBase
    {

        public SummaryController()
        {

        }
        [HttpGet("calculate/odd/test")]
        public async Task<IActionResult> CalculateOddGet()
        {
            var numbers = new int[] { -1, 2, 3, 4, 5, 6, 7, 8 };
            var json = new StringContent(JsonSerializer.Serialize(numbers), Encoding.UTF8, "application/json");

            using var httpClient = new HttpClient();
            var request = await httpClient.PostAsync("https://localhost:7243/api/summary/calculate", json);
            var response = await request.Content.ReadAsStringAsync();
            return Ok(response);

        }
        [HttpPost("calculate/odd")]
        public async Task<IActionResult> CalculateOddPost([FromBody] int[] numbers)
        {
            if (numbers.Length == 0) return BadRequest(new
            {
                message = "Array was empty"
            });

            var json = new StringContent(JsonSerializer.Serialize(numbers), Encoding.UTF8, "application/json");

            using var httpClient = new HttpClient();
            var request = await httpClient.PostAsync("https://localhost:7243/api/summary/calculate", json);
            var response = await request.Content.ReadAsStringAsync();
            return Ok(response);
        }
    }
}
