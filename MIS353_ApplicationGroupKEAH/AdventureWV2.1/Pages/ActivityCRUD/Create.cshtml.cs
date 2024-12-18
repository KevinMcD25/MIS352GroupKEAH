﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdventureWV2._1.Data;

namespace AdventureWV2._1.Pages.ActivityCRUD
{
    public class CreateModel : PageModel
    {
        private readonly AdventureWV2._1.Data.AdventureWvContext _context;

        public CreateModel(AdventureWV2._1.Data.AdventureWvContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Activity Activity { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Add Activity
            _context.Activities.Add(Activity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
