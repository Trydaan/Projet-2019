using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AboMag.Models;

namespace AboMag.Pages.Publications
{
    public class IndexModel : PageModel
    {
        private readonly AboMag.Models.AboMagContext _context;

        public IndexModel(AboMag.Models.AboMagContext context)
        {
            _context = context;
        }

        public IList<Publication> Publication { get;set; }

        public async Task OnGetAsync()
        {
            Publication = await _context.Publication.ToListAsync();
        }
    }
}
