﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MIS353_ApplicationGroupKEAH.Data;

namespace MIS353_ApplicationGroupKEAH.Pages.ActivityAdd
{
    public class EditModel : PageModel
    {
        private readonly MIS353_ApplicationGroupKEAH.Data.AdventureWvContext _context;

        public EditModel(MIS353_ApplicationGroupKEAH.Data.AdventureWvContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Activity Activity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity =  await _context.Activities.FirstOrDefaultAsync(m => m.Aid == id);
            if (activity == null)
            {
                return NotFound();
            }
            Activity = activity;
           ViewData["Lid"] = new SelectList(_context.Landmarks, "Lid", "Lid");
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

            _context.Attach(Activity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityExists(Activity.Aid))
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

        private bool ActivityExists(int id)
        {
            return _context.Activities.Any(e => e.Aid == id);
        }
    }
}
