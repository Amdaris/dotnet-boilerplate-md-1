using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge3 : ControllerBase
    {
        [HttpPost("chalange-3")]
        public int SmallestPositiveInteger([FromBody] int[] array)
        {
            // Write the code for Challenge 3 here

            return 0;
        }
    }
}
