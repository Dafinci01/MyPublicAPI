using Microsoft.AspNetCore.Mvc;
using System;

namespace MyPublicAPI.Controllers
{
    [ApiController]
    [Route("/")]  // Set this to root ("/") instead of "api/[controller]"
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var response = new
            {
                Email = "odelanadavidp20@gmail.com",  // Replace with your email
                Timestamp = DateTime.UtcNow.ToString("o"),  // ISO 8601 format
                GitHubUrl = "https://github.com/Dafinci01/MyPublicAPI"  // Your GitHub repo
            };

            return Ok(response);
        }
    }
}

