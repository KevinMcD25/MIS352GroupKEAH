using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIS353_ApplicationGroupKEAH.Data;

namespace MIS353_ApplicationGroupKEAH.Pages.UserTravelAdd
{
    public class DeleteModel : PageModel
    {
        private readonly MIS353_ApplicationGroupKEAH.Data.AdventureWvContext _context;

        public DeleteModel(MIS353_ApplicationGroupKEAH.Data.AdventureWvContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserTravel UserTravel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usertravel = await _context.UserTravels.FirstOrDefaultAsync(m => m.Utid == id);

            if (usertravel == null)
            {
                return NotFound();
            }
            else
            {
                UserTravel = usertravel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usertravel = await _context.UserTravels.FindAsync(id);
            if (usertravel != null)
            {
                UserTravel = usertravel;
                _context.UserTravels.Remove(UserTravel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
