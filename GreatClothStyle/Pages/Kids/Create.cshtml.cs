using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GreatClothStyle.Data;
using GreatClothStyle.Models;

namespace GreatClothStyle.Pages.Kids
{
    public class CreateModel : PageModel
    {
        private readonly GreatClothStyle.Data.GreatClothStyleContext _context;

        public CreateModel(GreatClothStyle.Data.GreatClothStyleContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public kids kids { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.kids.Add(kids);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
