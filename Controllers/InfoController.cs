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
                "email" = "odelanadavidp20@gmail.com","current_datetime" = DateTime.UtcNow.ToString("o"), "gitHub_Url" = "https://github.com/Dafinci01/MyPublicAPI"  // Your GitHub repo};

            return Ok(response);
        }
    }
}

