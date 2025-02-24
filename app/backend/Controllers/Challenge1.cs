using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge1 : ControllerBase
    {
        [HttpPost("chalange-1")]
        public int GetMajorityElement([FromBody] int[] array)
        {
            // Write the code for Challenge 1 here

            return 0;
        }
    }
}
