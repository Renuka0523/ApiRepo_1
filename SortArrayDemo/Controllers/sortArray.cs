using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SortArrayDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sortArray : ControllerBase
    {
        [HttpGet(Name = "getsortArry")]

        public IActionResult getsortArray([FromQuery] int[] numbers)
        {
            return Ok("sortArry numbers:" + numbers + "and" + numbers + "and" + numbers + "and" + numbers);
        }
    }
}
