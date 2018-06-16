using System.Diagnostics.Contracts;

namespace WarehouseControl.Models
{
    public class OrdersSchedule
    {
        public Supplier Supplier { get; set; }
        public string Contract { get; set; }
        public int Gap { get; set; }

    }
}
