using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesForYou.Data;
using MoviesForYou.Data.Models;

namespace MoviesForYou.Web.Pages.Keywords
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Keyword> Keyword { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Keywords != null)
            {
                Keyword = await _context.Keywords.ToListAsync();
            }
        }
    }
}
