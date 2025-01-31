using Microsoft.AspNetCore.Mvc;
using System;

namespace MyPublicAPI.Controllers
{
    [ApiController]
    [Route("/")]  // Root route ("/") instead of "api/[controller]"
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var response = new
            {
                email = "odelanadavidp20@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"),  // Corrected format string
                github_url = "https://github.com/Dafinci01/MyPublicAPI"
            };

            return Ok(response);  // This line needs to be properly closed with a semicolon
        }
    }
}

