using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskASP.NetCore.Models;

namespace MegaDeskASP.NetCore.Data
{
    public class MegaDeskASPNetCoreContext : DbContext
    {
        public MegaDeskASPNetCoreContext (DbContextOptions<MegaDeskASPNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskASP.NetCore.Models.Desk> Desk { get; set; } = default!;
    }
}
