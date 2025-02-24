using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge2 : ControllerBase
    {
        [HttpPost("chalange-2")]
        public int UniqueNumber([FromBody] int[] array)
        {
            // Write the code for Challenge 2 here

            return 0;
        }
    }
}
