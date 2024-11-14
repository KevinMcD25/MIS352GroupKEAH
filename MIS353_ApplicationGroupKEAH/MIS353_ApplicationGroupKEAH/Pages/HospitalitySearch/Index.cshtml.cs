using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIS353_ApplicationGroupKEAH.Data;
using System.Net.Http;

namespace MIS353_ApplicationGroupKEAH.Pages.HospitalitySearch
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IList<Hospitality> Hospitality { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string Htype)
        {
            if (string.IsNullOrEmpty(Htype))
            {
                return Page();
            }
            try
            {
                //Made the endpoint string
                string requestUrl = $"https://localhost:7151/api/Hospitality/SearchHType?HType={Uri.EscapeDataString(Htype)}";
                //Send GET Request to API

                Hospitality = await _httpClient.GetFromJsonAsync<IList<Hospitality>>(requestUrl) ?? new List<Hospitality>();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            return Page();
        }
    }
}

