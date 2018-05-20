using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WarehouseControl.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext _context;
        public EFOrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Order> Orders => _context.Orders;
    }
}
