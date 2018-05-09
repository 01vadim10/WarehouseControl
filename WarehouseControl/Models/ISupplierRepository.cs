using System.Linq;

namespace WarehouseControl.Models
{
    public interface ISupplierRepository
    {
        IQueryable<Supplier> Suppliers { get; }
    }
}
