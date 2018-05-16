using System.Collections.Generic;
using WarehouseControl.Models.ViewModels;

namespace WarehouseControl.Models
{
    public class OrdersListViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
