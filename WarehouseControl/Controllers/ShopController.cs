using Microsoft.AspNetCore.Mvc;
using WarehouseControl.Models;

namespace WarehouseControl.Controllers
{
    public class ShopController : Controller
    {
	    private IShopRepository _repository;

	    public ShopController(IShopRepository repository)
	    {
		    _repository = repository;
	    }

	    public ViewResult List() => View(_repository.Shops);
    }
}