using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using WarehouseControl.Controllers;
using WarehouseControl.Models;
using Xunit;

namespace WarehouseControl.xTest
{
    public class ShopControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            Mock<IShopRepository> mock = new Mock<IShopRepository>();
            mock.Setup(m => m.Shops).Returns((new Shop[]
            {
                new Shop {ShopId = 1, Name = "Sh1"},
                new Shop {ShopId = 2, Name = "Sh2"},
                new Shop {ShopId = 3, Name = "Sh3"},
                new Shop {ShopId = 4, Name = "Sh4"},
                new Shop {ShopId = 5, Name = "Sh5"}
            }).AsQueryable<Shop>());

            ShopController controller = new ShopController(mock.Object);
            controller.pageSize = 3;

            //Act
            IEnumerable<Shop> result =
                controller.List(2).ViewData.Model as IEnumerable<Shop>;

            //Assert
            Shop[] shopArray = result.ToArray();
            Assert.True(shopArray.Length == 2);
            Assert.Equal("Sh4", shopArray[0].Name);
            Assert.Equal("Sh5", shopArray[1].Name);
        }
    }
}
