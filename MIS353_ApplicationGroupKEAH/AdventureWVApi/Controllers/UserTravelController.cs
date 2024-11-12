using AdventureWVApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdventureWVApi.Data;
using System.Collections.Generic;

namespace AdventureWVApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTravelController : ControllerBase
    {
        private readonly IUserTravelService UserTravelService;

        public UserTravelController(IUserTravelService UserTravelService)
        {
            this.UserTravelService = UserTravelService;
        }
        [HttpDelete("UserTravelDelete")]

    public async Task<IActionResult> UserTravelAsync(int UTID)
        {

                var response = await UserTravelService.UserTravelDelete(UTID);
                return Ok(response);
           
        }
        [HttpPost("AddUserTravel")]
        public async Task<IActionResult> UserTravelAdd(int Pid, int Uid, DateTime UTDateTime)
        {
            var response = await UserTravelService.UserTravelAdd(Pid, Uid, UTDateTime);
            return Ok(response);
        }
    }
}
