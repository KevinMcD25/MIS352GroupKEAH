using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdventureWV2._1.Data;

namespace AdventureWV2._1.Pages.ActivityCRUD
{
    public class IndexModel : PageModel
    {
        private readonly AdventureWV2._1.Data.AdventureWvContext _context;

        public IndexModel(AdventureWV2._1.Data.AdventureWvContext context)
        {
            _context = context;
        }

        public IList<Activity> Activity { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Activity = await _context.Activities.ToListAsync();
        }
    }
}
