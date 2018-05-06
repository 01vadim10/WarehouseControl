namespace WarehouseControl.Models
{
    public class Shop
    {
		public int ShopID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }

		public Shop()
		{
		}

		public bool Create(string name, string addr)
	    {
		    return false;
	    }
    }
}
