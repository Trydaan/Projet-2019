using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AboMag.Models;

namespace AboMag.Pages.Publications
{
    public class CreateModel : PageModel
    {
        private readonly AboMag.Models.AboMagContext _context;

        public CreateModel(AboMag.Models.AboMagContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publication Publication { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publication.Add(Publication);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}