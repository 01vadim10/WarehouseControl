namespace WarehouseControl.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string BarCode { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Measure { get; set; }
        public int Weight { get; set; }
        public int TradeSurcharge { get; set; }
        public int VAT { get; set; }
        public string Category { get; set; }

        public Product() { }
    }
}
