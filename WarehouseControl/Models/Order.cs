using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseControl.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Shop Shop { get; set; }
        public Supplier Supplier { get; set; }
        public string Contract { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата поставки")]
        public DateTime SupplyDate { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
