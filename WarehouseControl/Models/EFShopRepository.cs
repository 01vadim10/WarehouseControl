using System.Linq;

namespace WarehouseControl.Models
{
    public class EFShopRepository : IShopRepository
    {
        private ApplicationDbContext _context;

        public EFShopRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Shop> Shops => _context.Shops;
    }
}
