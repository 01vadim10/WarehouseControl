using System;

namespace WarehouseControl.Models
{
    public class Order
    {
        public int PurchaseId { get; set; }
        public Shop Shop { get; set; }
        public Supplier Supplier { get; set; }
        public string Contract { get; set; }
        public DateTime SupplyDate { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
