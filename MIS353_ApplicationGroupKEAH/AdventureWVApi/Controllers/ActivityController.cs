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
        [HttpPost("AddActivity2")]
        public async Task<IActionResult> AddActivityAsync(string Aname, int Lid)
        {
            
            try
            {
                var response = await ActivityService.AddActivity2(Aname, Lid);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
       // [HttpPut("UpdateActivities")]
      //  public async Task<IActionResult> UpdateActivitiesAsync(string Aname, int Lid)
      //  {
           
         //   try
            /// <summary>
            /// /{
            /// </summary>
               // var result = await ActivityService.UpdateActivities(Aname, Lid);
                //return Ok(result);
            ////}
            //catch
            //{
               // throw;
            //}
        }
    }

