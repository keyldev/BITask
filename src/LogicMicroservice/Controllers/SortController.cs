using LogicMicroservice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static LogicMicroservice.Services.SortService;

namespace LogicMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortController : ControllerBase
    {
        private readonly ISortService _sortService;
        public SortController(ISortService sortService)
        {
            _sortService = sortService;
        }

        [HttpGet]
        public IActionResult Get() // example get
        {
            MyList<int> list = new MyList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(5);
            list.Add(3);
            var result = _sortService.BubbleSort(list);
            //foreach(var item in result)
            //    Debug.WriteLine(item);
            return Ok(result);
            // Data Transfer Object
            //return Ok(new
            //{
            //    data = result
            //});
        }
        [HttpPost("bubble")] 
        public IActionResult BubbleSort([FromBody] int[] list)
        {

            var numbers = new MyList<int>(list);

            var result = _sortService.BubbleSort(numbers);
            return Ok(result);
        }
    }
}
