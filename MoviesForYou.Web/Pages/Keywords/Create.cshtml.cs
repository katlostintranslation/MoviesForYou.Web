using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesForYou.Data;
using MoviesForYou.Data.Models;

namespace MoviesForYou.Web.Pages.Keywords
{
    public class CreateModel : PageModel
    {
        private readonly MoviesForYou.Data.ApplicationDbContext _context;

        public CreateModel(MoviesForYou.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Keyword Keyword { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Keywords.Add(Keyword);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
