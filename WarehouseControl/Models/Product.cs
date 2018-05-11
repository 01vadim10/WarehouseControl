namespace WarehouseControl.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public long Code { get; set; }
        public long BarCode { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Measure { get; set; }
        public double Weight { get; set; }
        public int TradeSurcharge { get; set; }
        public int VAT { get; set; }
        public string Category { get; set; }

        public Product() { }
    }
}
