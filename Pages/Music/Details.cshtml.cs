using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMusic.Models;

namespace RazorPagesMusic.Pages_Music
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMusicContext _context;

        public DetailsModel(RazorPagesMusicContext context)
        {
            _context = context;
        }

        public Music Music { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Music = await _context.Music.FirstOrDefaultAsync(m => m.ID == id);

            if (Music == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
