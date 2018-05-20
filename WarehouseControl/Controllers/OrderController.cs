using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WarehouseControl.Models;

namespace WarehouseControl.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ViewResult Index()
            => View(_context.Orders);
    }
}
