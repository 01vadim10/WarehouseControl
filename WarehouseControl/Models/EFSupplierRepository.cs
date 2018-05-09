using System.Linq;

namespace WarehouseControl.Models
{
    public class EFSupplierRepository : ISupplierRepository
    {
        private ApplicationDbContext _context;

        public EFSupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Supplier> Suppliers => _context.Suppliers;
    }
}
