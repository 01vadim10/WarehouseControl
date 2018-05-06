using System.Linq;

namespace WarehouseControl.Models
{
    public interface IShopRepository
    {
		IQueryable<Shop> Shops { get; }
    }
}
