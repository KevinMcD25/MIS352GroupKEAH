using AdventureWVApi.Data;
using AdventureWVApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdventureWVApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService ActivityService;
        public ActivityController(IActivityService activityService)
        {
            this.ActivityService = activityService;
        }
        [HttpPost("addactivity")]
        public async Task<IActionResult> AddActivityAsync(Activity activity)
        {
            if (activity == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await ActivityService.ActivityAdd2(activity);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
        [HttpPut("updateactivity")]
        public async Task<IActionResult> UpdateActivityAsync(Activity activity)
        {
            if (activity == null)
            {
                return BadRequest();
            }
            try
            {
                var result = await ActivityService.UpdateActivity(activity);
                return Ok(result);
            }
            catch
            {
                throw;
            }
        }
    }
}
