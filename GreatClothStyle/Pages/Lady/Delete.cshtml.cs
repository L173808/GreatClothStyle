using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GreatClothStyle.Data;
using GreatClothStyle.Models;

namespace GreatClothStyle.Pages.Lady
{
    public class DeleteModel : PageModel
    {
        private readonly GreatClothStyle.Data.GreatClothStyleContext _context;

        public DeleteModel(GreatClothStyle.Data.GreatClothStyleContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Women Women { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Women = await _context.Women.FirstOrDefaultAsync(m => m.id == id);

            if (Women == null)
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

            Women = await _context.Women.FindAsync(id);

            if (Women != null)
            {
                _context.Women.Remove(Women);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
