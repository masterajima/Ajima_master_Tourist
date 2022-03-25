using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMusic.Models;

namespace RazorPagesMusic.Pages_Music
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMusicContext _context;

        public IndexModel(RazorPagesMusicContext context)
        {
            _context = context;
        }

        public IList<Music> Music { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MusicGenre { get; set; }

        public async Task OnGetAsync()
        {
            var music = from m in _context.Music
                 select m;
    if (!string.IsNullOrEmpty(SearchString))
    {
        music = music.Where(s => s.Album.Contains(SearchString));
    }
            Music = await _context.Music.ToListAsync();
        }
    }
}
