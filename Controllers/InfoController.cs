using Microsoft.AspNetCore.Mvc;
using System;

namespace MyPublicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {
        // This endpoint will return the desired info
        [HttpGet]
        public IActionResult GetInfo()
        {
            var response = new
            {
                Email = "odelanadavidp20@gmail.com",  // Replace with your email
                Timestamp = DateTime.UtcNow.ToString("o"),  // ISO 8601 format
                GitHubUrl = "https://github.com/Dafinci01/MyPublicAPI"  // Replace with your GitHub repo
            };

            return Ok(response);  // Return the response as JSON
        }
    }
}

