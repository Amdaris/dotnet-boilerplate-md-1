using backend.Models;

using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge3 : ControllerBase
    {
        [HttpPost("challenge-3")]
        public string Implementation([FromBody] RestaurantOrderRequest input)
        {
            string order = input.Order;

            // Write the code for Challenge 3 here

            return "";
        }
    }
}
