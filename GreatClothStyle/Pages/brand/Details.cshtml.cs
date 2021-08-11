using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GreatClothStyle.Data;
using GreatClothStyle.Models;

namespace GreatClothStyle.Pages.brand
{
    public class DetailsModel : PageModel
    {
        private readonly GreatClothStyle.Data.GreatClothStyleContext _context;

        public DetailsModel(GreatClothStyle.Data.GreatClothStyleContext context)
        {
            _context = context;
        }

        public Brand Brand { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Brand = await _context.Brand.FirstOrDefaultAsync(m => m.id == id);

            if (Brand == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
