﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdventureWV2._1.Data;

namespace AdventureWV2._1.Pages.LandmarkCRUD
{
    //Delete Landmark
    public class DeleteModel : PageModel
    {
        private readonly AdventureWV2._1.Data.AdventureWvContext _context;

        public DeleteModel(AdventureWV2._1.Data.AdventureWvContext context)
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

            var landmark = await _context.Landmarks.FirstOrDefaultAsync(m => m.Lid == id);

            if (landmark == null)
            {
                return NotFound();
            }
            else
            {
                Landmark = landmark;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landmark = await _context.Landmarks.FindAsync(id);
            if (landmark != null)
            {
                Landmark = landmark;
                _context.Landmarks.Remove(Landmark);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
