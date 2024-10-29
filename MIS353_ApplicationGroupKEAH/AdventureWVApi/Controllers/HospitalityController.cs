using AdventureWVApi.Data;
using AdventureWVApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWVApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HospitalityController : ControllerBase
    {
        private readonly IHospitalityService HospitalityService;
        public HospitalityController(IHospitalityService HospitalityService)
        {
            this.HospitalityService = HospitalityService;
        }
        [HttpPost("SearchHType")]
        public async Task<IActionResult> SearchHotelAsync(
            string HType = null)
        {
            if (SearchHotelAsync == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await HospitalityService.SearchHType(HType);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
        [HttpPut("AddHospitality")]
        public async Task<IActionResult> AddHopiality(Hospitality hospitality)
        {
            if (hospitality == null)
            {
                return BadRequest();
            }
            try
            {
                var result = await HospitalityService.AddHospitality(hospitality);
                return Ok(result);
            }
            catch
            {
                throw;
            }
        }
    }
}
