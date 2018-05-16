using System.Linq;

namespace WarehouseControl.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Order> Purchases { get; }
    }
}
