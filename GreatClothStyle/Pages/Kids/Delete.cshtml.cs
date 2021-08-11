using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GreatClothStyle.Data;
using GreatClothStyle.Models;

namespace GreatClothStyle.Pages.Kids
{
    public class DeleteModel : PageModel
    {
        private readonly GreatClothStyle.Data.GreatClothStyleContext _context;

        public DeleteModel(GreatClothStyle.Data.GreatClothStyleContext context)
        {
            _context = context;
        }

        [BindProperty]
        public kids kids { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            kids = await _context.kids.FirstOrDefaultAsync(m => m.id == id);

            if (kids == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            kids = await _context.kids.FindAsync(id);

            if (kids != null)
            {
                _context.kids.Remove(kids);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
