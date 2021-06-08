using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster4.Data;
using RazorPagesMonster4.Models;

namespace RazorPagesMonster4.Pages.Monsters
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMonster4.Data.RazorPagesMonster4Context _context;

        public DetailsModel(RazorPagesMonster4.Data.RazorPagesMonster4Context context)
        {
            _context = context;
        }

        public Monster Monster { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monster = await _context.Monster.FirstOrDefaultAsync(m => m.ID == id);

            if (Monster == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
