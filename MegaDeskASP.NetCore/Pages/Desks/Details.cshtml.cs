using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskASP.NetCore.Data;
using MegaDeskASP.NetCore.Models;

namespace MegaDeskASP.NetCore.Pages.Desks
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskASP.NetCore.Data.MegaDeskASPNetCoreContext _context;

        public DetailsModel(MegaDeskASP.NetCore.Data.MegaDeskASPNetCoreContext context)
        {
            _context = context;
        }

      public Desk Desk { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Desk == null)
            {
                return NotFound();
            }

            var desk = await _context.Desk.FirstOrDefaultAsync(m => m.Id == id);
            if (desk == null)
            {
                return NotFound();
            }
            else 
            {
                Desk = desk;
            }
            return Page();
        }
    }
}
