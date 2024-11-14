using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MIS353_ApplicationGroupKEAH.Data;

namespace MIS353_ApplicationGroupKEAH.Pages.HospitalitySearch
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
        ViewData["Lid"] = new SelectList(_context.Landmarks, "Lid", "Lid");
            return Page();
        }

        [BindProperty]
        public Hospitality Hospitality { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Hospitalities.Add(Hospitality);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
