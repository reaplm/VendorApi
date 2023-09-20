using Microsoft.EntityFrameworkCore;
using Vendor.Domain.Entitities;

namespace Vendor.Infrastructure.Context
{
	public class VendorContext : DbContext
	{
        public DbSet<Merchant> Merchants { set; get; }

		public VendorContext(DbContextOptions options) : base(options)
		{
		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

