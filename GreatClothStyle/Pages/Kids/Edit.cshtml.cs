using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GreatClothStyle.Data;
using GreatClothStyle.Models;

namespace GreatClothStyle.Pages.Kids
{
    public class EditModel : PageModel
    {
        private readonly GreatClothStyle.Data.GreatClothStyleContext _context;

        public EditModel(GreatClothStyle.Data.GreatClothStyleContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(kids).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!kidsExists(kids.id))
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

        private bool kidsExists(int id)
        {
            return _context.kids.Any(e => e.id == id);
        }
    }
}
