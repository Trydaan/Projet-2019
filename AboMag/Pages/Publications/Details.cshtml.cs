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
    public class DetailsModel : PageModel
    {
        private readonly AboMag.Models.AboMagContext _context;

        public DetailsModel(AboMag.Models.AboMagContext context)
        {
            _context = context;
        }

        public Publication Publication { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publication = await _context.Publication.FirstOrDefaultAsync(m => m.Id == id);

            if (Publication == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
