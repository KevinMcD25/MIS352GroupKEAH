using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdventureWV2._1.Data;

namespace AdventureWV2._1.Pages.TravelplanCRUD
{
    //Delete Travel Plan
    public class DeleteModel : PageModel
    {
        private readonly AdventureWV2._1.Data.AdventureWvContext _context;

        public DeleteModel(AdventureWV2._1.Data.AdventureWvContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Travelplan Travelplan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelplan = await _context.Travelplans.FirstOrDefaultAsync(m => m.Pid == id);

            if (travelplan == null)
            {
                return NotFound();
            }
            else
            {
                Travelplan = travelplan;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelplan = await _context.Travelplans.FindAsync(id);
            if (travelplan != null)
            {
                Travelplan = travelplan;
                _context.Travelplans.Remove(Travelplan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
