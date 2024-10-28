using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AdventureWVApi.Repositories;
using AdventureWVApi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdventureWVApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelplanController : ControllerBase
    {
        private readonly ITravelplanService TravelplanService;
        public TravelplanController(ITravelplanService TravelplanService)
        {
            this.TravelplanService = TravelplanService;
        }
        [HttpPost("PlanAdd")]
        public async Task<IActionResult> PlanAddAsync(Travelplan travelplan)
            {
                

            if (travelplan == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await TravelplanService.PlanAdd(travelplan);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }

        [HttpDelete("deleteplan")]
        public async Task<IActionResult> PlanDelete(int Pid)
        {
            var response = await TravelplanService.PlanDelete(Pid);
            return  Ok(response);
        }
        
    }
}
