using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AdventureWVApi.Repositories;
using AdventureWVApi.Data;
using Microsoft.Identity.Client;

namespace AdventureWVApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandmarkController : ControllerBase
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
            [HttpGet("SearchLType")]
            public async Task<IActionResult> SearchLandmarkAsync( string Ltype = null)
            {
                if (SearchLandmarkAsync == null)
                {
                    return BadRequest();
                }
                try
                {
                    var response = await LandmarkService.SearchLType(Ltype);
                    return Ok(response);
                }
                catch
                {
                    throw;
                }
            }
        }
    }

