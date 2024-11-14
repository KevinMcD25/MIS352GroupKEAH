using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdventureWv2._0.Data;

namespace AdventureWv2._0.Pages.LandmarkCRUD
{
    public class EditModel : PageModel
    {
        private readonly AdventureWv2._0.Data.AdventureWvContext _context;

        public EditModel(AdventureWv2._0.Data.AdventureWvContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Landmark Landmark { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landmark =  await _context.Landmarks.FirstOrDefaultAsync(m => m.Lid == id);
            if (landmark == null)
            {
                return NotFound();
            }
            Landmark = landmark;
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

            _context.Attach(Landmark).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LandmarkExists(Landmark.Lid))
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

        private bool LandmarkExists(int id)
        {
            return _context.Landmarks.Any(e => e.Lid == id);
        }
    }
}
