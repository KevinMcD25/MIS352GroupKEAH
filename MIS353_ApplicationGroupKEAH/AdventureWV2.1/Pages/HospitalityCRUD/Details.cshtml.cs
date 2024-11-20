using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdventureWV2._1.Data;

namespace AdventureWV2._1.Pages.HospitalityCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly AdventureWV2._1.Data.AdventureWvContext _context;

        public DetailsModel(AdventureWV2._1.Data.AdventureWvContext context)
        {
            _context = context;
        }

        public Hospitality Hospitality { get; set; } = default!;

        //Sort by ID
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitality = await _context.Hospitalities.FirstOrDefaultAsync(m => m.Hid == id);
            if (hospitality == null)
            {
                return NotFound();
            }
            else
            {
                Hospitality = hospitality;
            }
            return Page();
        }
    }
}
