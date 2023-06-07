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
    public class IndexModel : PageModel
    {
        private readonly MegaDeskASP.NetCore.Data.MegaDeskASPNetCoreContext _context;

        public IndexModel(MegaDeskASP.NetCore.Data.MegaDeskASPNetCoreContext context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Desk != null)
            {
                Desk = await _context.Desk.ToListAsync();
            }
        }
    }
}
