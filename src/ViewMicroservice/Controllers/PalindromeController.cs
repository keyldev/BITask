using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;

namespace ViewMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromeController : ControllerBase
    {
        public PalindromeController()
        {

        }
        [HttpGet("test")]
        public async Task<IActionResult> PalindromeGetAsync()
        {
            var source = "madam";
            var json = new StringContent(JsonSerializer.Serialize(source), Encoding.UTF8, "application/json");

            using var httpClient = new HttpClient();
            var request = await httpClient.PostAsync("https://localhost:7243/api/palindrome", json);
            var response = await request.Content.ReadAsStringAsync();
            return Ok(response);
        }
        [HttpPost("check")]
        public async Task<IActionResult> CalculateOddPost([FromBody] string source)
        {
            if (source.Length == 0) return BadRequest(new
            {
                message = "String was empty"
            });

            var json = new StringContent(JsonSerializer.Serialize(source), Encoding.UTF8, "application/json");

            using var httpClient = new HttpClient();
            var request = await httpClient.PostAsync("https://localhost:7243/api/palindrome", json);
            var response = await request.Content.ReadAsStringAsync();
            return Ok(response);
        }

    }
}
