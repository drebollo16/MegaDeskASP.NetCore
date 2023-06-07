using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskASP.NetCore.Data;
using MegaDeskASP.NetCore.Models;

namespace MegaDeskASP.NetCore.Pages.Desks
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskASP.NetCore.Data.MegaDeskASPNetCoreContext _context;

        public CreateModel(MegaDeskASP.NetCore.Data.MegaDeskASPNetCoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Desk Desk { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Desk == null || Desk == null)
            {
                return Page();
            }

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
