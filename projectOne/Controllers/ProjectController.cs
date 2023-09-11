using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace projectOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
     

        [HttpGet]
        public IActionResult Get(
            [FromQuery] string slack_name,
            [FromQuery] string track)
        {
            // Get the current day of the week and UTC time
            var currentDay = DateTime.UtcNow.ToString("dddd", CultureInfo.InvariantCulture);
            var utcTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

            // Construct the response JSON object
            var response = new
            {
                slack_name = slack_name,
                current_day = currentDay,
                utc_time = utcTime,
                track = track,
                github_file_url = "https://github.com/username/repo/blob/main/file_name.ext",
                github_repo_url = "https://github.com/username/repo",
                status_code = 200
            };

            return Ok(response);
        }
    }
}

