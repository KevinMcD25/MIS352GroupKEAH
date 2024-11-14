using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIS353_ApplicationGroupKEAH.Data;

namespace MIS353_ApplicationGroupKEAH.Pages.HospitalityAdd
{
    public class IndexModel : PageModel
    {
        private readonly MIS353_ApplicationGroupKEAH.Data.AdventureWvContext _context;

        public IndexModel(MIS353_ApplicationGroupKEAH.Data.AdventureWvContext context)
        {
            _context = context;
        }

        public IList<Hospitality> Hospitality { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Hospitality = await _context.Hospitalities
                .Include(h => h.LidNavigation).ToListAsync();
        }
    }
}
