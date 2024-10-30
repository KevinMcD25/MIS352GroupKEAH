using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AdventureWVApi.Repositories;
using AdventureWVApi.Data;

namespace AdventureWVApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandmarkController : Controller
    {
        private readonly ILandmarkService LandmarkService;

        public LandmarkController(ILandmarkService LandmarkService)
        {
            this.LandmarkService = LandmarkService;
        }

        [HttpPost("LandmarkAdd")]
        public async Task<IActionResult> LandmarkAddAsync(string Lname, string Ltype)
        {
            try
            {
                var response = await LandmarkService.LandmarkAdd(Lname, Ltype);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}
