using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AboMag.Models;

namespace AboMag.Pages.Publications
{
    public class EditModel : PageModel
    {
        private readonly AboMag.Models.AboMagContext _context;

        public EditModel(AboMag.Models.AboMagContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Publication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublicationExists(Publication.Id))
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

        private bool PublicationExists(int id)
        {
            return _context.Publication.Any(e => e.Id == id);
        }
    }
}
