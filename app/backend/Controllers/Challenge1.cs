using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge1 : ControllerBase
    {
        [HttpPost("challenge-1")]
        public int Implementation([FromBody] int[] array)
        {
            // Write the code for Challenge 1 here

            return 0;
        }
    }
}
