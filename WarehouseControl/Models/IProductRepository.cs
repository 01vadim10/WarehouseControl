using System.Linq;

namespace WarehouseControl.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
