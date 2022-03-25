using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMusic.Models;

namespace RazorPagesMusic.Pages_Music
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMusicContext _context;

        public CreateModel(RazorPagesMusicContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Music Music { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Music.Add(Music);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
