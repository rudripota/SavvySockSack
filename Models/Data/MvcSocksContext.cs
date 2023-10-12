using Microsoft.EntityFrameworkCore;
using SavvySockSack.Models;

namespace SavvySockSack.Data
{
    public class MvcSocksContext : DbContext
    {
        public MvcSocksContext(DbContextOptions<MvcSocksContext> options)
            : base(options)
        {
        }

        public DbSet<Socks> Socks { get; set; }
    }
}
