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
    public class DeleteModel : PageModel
    {
        private readonly MoviesForYou.Data.ApplicationDbContext _context;

        public DeleteModel(MoviesForYou.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Keyword Keyword { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Keywords == null)
            {
                return NotFound();
            }

            var keyword = await _context.Keywords.FirstOrDefaultAsync(m => m.Id == id);

            if (keyword == null)
            {
                return NotFound();
            }
            else 
            {
                Keyword = keyword;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Keywords == null)
            {
                return NotFound();
            }
            var keyword = await _context.Keywords.FindAsync(id);

            if (keyword != null)
            {
                Keyword = keyword;
                _context.Keywords.Remove(Keyword);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
