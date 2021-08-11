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
    public class IndexModel : PageModel
    {
        private readonly GreatClothStyle.Data.GreatClothStyleContext _context;

        public IndexModel(GreatClothStyle.Data.GreatClothStyleContext context)
        {
            _context = context;
        }

        public IList<kids> kids { get;set; }

        public async Task OnGetAsync()
        {
            kids = await _context.kids.ToListAsync();
        }
    }
}
