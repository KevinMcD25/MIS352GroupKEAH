﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdventureWV2._1.Data;

namespace AdventureWV2._1.Pages.UsertravelCRUD
{
    //Delete Usertravel
    public class DeleteModel : PageModel
    {
        private readonly AdventureWV2._1.Data.AdventureWvContext _context;

        public DeleteModel(AdventureWV2._1.Data.AdventureWvContext context)
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
