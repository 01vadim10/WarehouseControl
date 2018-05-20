using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace WarehouseControl.Models
{
    public class ApplicationDbContext : DbContext
    {
	    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

//        public class ApplicationDbContextFactory
//            : IDesignTimeDbContextFactory<ApplicationDbContext>
//        {
//
//            public ApplicationDbContext CreateDbContext(string[] args) =>
//                Program.BuildWebHost(args).Services
//                    .GetRequiredService<ApplicationDbContext>();
//        }
    }
}
