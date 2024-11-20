using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdventureWV2._1.Data;

namespace AdventureWV2._1.Pages.HospitalityCRUD
{
    public class IndexModel : PageModel
    {
        private readonly AdventureWV2._1.Data.AdventureWvContext _context;

        public IndexModel(AdventureWV2._1.Data.AdventureWvContext context)
        {
            _context = context;
        }
        
        //List CRUD options
        public IList<Hospitality> Hospitality { get;set; } = default!;
        
        public async Task OnGetAsync()
        {
            Hospitality = await _context.Hospitalities.ToListAsync();
        }
    }
}
