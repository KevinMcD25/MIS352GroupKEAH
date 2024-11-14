using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdventureWv2._0.Data;

namespace AdventureWv2._0.Pages.LandmarkCRUD
{
    public class CreateModel : PageModel
    {
        private readonly AdventureWv2._0.Data.AdventureWvContext _context;

        public CreateModel(AdventureWv2._0.Data.AdventureWvContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Landmark Landmark { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Landmarks.Add(Landmark);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
