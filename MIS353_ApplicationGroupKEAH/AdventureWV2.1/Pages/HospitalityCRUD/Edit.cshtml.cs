using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdventureWV2._1.Data;

namespace AdventureWV2._1.Pages.HospitalityCRUD
{
    public class EditModel : PageModel
    {
        private readonly AdventureWV2._1.Data.AdventureWvContext _context;

        public EditModel(AdventureWV2._1.Data.AdventureWvContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hospitality Hospitality { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitality =  await _context.Hospitalities.FirstOrDefaultAsync(m => m.Hid == id);
            if (hospitality == null)
            {
                return NotFound();
            }
            Hospitality = hospitality;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Hospitality).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HospitalityExists(Hospitality.Hid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HospitalityExists(int id)
        {
            return _context.Hospitalities.Any(e => e.Hid == id);
        }
    }
}
