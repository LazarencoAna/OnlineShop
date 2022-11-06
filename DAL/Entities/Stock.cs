namespace OnlineShop.DAL.Entities
{
    public class Stock
    {
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public SizeEnum Size { get; set; }
        public string Color { get; set; }
    }
}