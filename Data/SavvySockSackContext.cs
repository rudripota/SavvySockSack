using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SavvySockSack.Models;

namespace SavvySockSack.Data
{
    public class SavvySockSackContext : DbContext
    {
        public SavvySockSackContext (DbContextOptions<SavvySockSackContext> options)
            : base(options)
        {
        }

        public DbSet<SavvySockSack.Models.Socks> Socks { get; set; }
    }
}
