using System.Collections.Generic;
using System.Linq;

namespace WarehouseControl.Models
{
    public class FakeShopRepository : IShopRepository
    {
	    public IQueryable<Shop> Shops => new List<Shop>
	    {
		    new Shop {Name = "Hyppo lite", Address = "Gonzaga st."},
		    new Shop {Name = "Hyppo mid", Address = "Red st."},
		    new Shop {Name = "Hyppo big", Address = "Central st."}
	    }.AsQueryable<Shop>();
    }
}
