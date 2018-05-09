using System.Linq;

namespace WarehouseControl.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private ApplicationDbContext _context;

        public EFPurchaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Purchase> Purchases => _context.Purchases;
    }
}
