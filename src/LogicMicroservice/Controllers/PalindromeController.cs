using LogicMicroservice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogicMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromeController : ControllerBase
    {
        private readonly IPalindromeService _palindromeService;
        public PalindromeController(IPalindromeService palindromeService)
        {
            _palindromeService = palindromeService;
        }

        [HttpPost()]
        public async Task<IActionResult> Palindrome([FromBody] string source)
        {
            var result = _palindromeService.IsPalindrome(source);
            return Ok(result);
        }

    }
}
