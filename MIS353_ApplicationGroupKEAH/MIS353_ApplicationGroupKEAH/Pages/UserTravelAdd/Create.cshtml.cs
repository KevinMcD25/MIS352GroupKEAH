using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MIS353_ApplicationGroupKEAH.Data;

namespace MIS353_ApplicationGroupKEAH.Pages.UserTravelAdd
{
    public class CreateModel : PageModel
    {
        private readonly MIS353_ApplicationGroupKEAH.Data.AdventureWvContext _context;

        public CreateModel(MIS353_ApplicationGroupKEAH.Data.AdventureWvContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Pid"] = new SelectList(_context.Travelplans, "Pid", "Pid");
        ViewData["Uid"] = new SelectList(_context.Userdata, "Uid", "Uid");
            return Page();
        }

        [BindProperty]
        public UserTravel UserTravel { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UserTravels.Add(UserTravel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
