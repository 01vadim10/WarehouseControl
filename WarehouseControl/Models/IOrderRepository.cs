using System.Linq;

namespace WarehouseControl.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
    }
}
