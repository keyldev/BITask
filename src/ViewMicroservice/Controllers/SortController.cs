using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;

namespace ViewMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortController : ControllerBase
    {

        public SortController()
        {

        }
        [HttpPost("bubble")]
        public async Task<IActionResult> BubbleSort([FromBody] int[] numbers)
        {
            var json = new StringContent(JsonSerializer.Serialize(numbers), Encoding.UTF8, "application/json");


            using var httpClient = new HttpClient();
            var request = await httpClient.PostAsync("https://localhost:7243/api/sort/bubble", json);
            var response = await request.Content.ReadAsStringAsync();
            return Ok(response);

        }
        [HttpGet("bubble/test")]
        public async Task<IActionResult> BubbleSortTest()
        {
            using var httpClient = new HttpClient();
            var request = await httpClient.GetAsync("https://localhost:7243/api/sort");
            var response = await request.Content.ReadAsStringAsync();
            return Ok(response);
        }

    }
}
