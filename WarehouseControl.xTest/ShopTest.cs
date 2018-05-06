using WarehouseControl.Models;
using Xunit;

namespace WarehouseControl.xTest
{
	public class ShopTest
	{
		private Shop _shop;

		public ShopTest()
		{
			_shop = new Shop();
		}

		[Fact]
		public void CreateShop()
		{
			var name = "FamousTestShop1";
			var address = "Boston, SomeTestStr st., 7 b.";
			var shopFormat = "";

			Assert.True(_shop.Create(name, address, shopFormat));
		}

		[Fact]
		public void ReadShop()
		{

		}
	}
}
