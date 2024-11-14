using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdventureWv2._0.Data;

namespace AdventureWv2._0.Pages.LandmarkCRUD
{
    public class IndexModel : PageModel
    {
        private readonly AdventureWv2._0.Data.AdventureWvContext _context;

        public IndexModel(AdventureWv2._0.Data.AdventureWvContext context)
        {
            _context = context;
        }

        public IList<Landmark> Landmark { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Landmark = await _context.Landmarks.ToListAsync();
        }
    }
}
