using System.Linq;

namespace WarehouseControl.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }
    }
}
