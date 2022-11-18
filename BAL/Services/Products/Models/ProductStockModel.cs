using OnlineShop.DAL.Entities;

namespace OnlineShop.BAL.Services.Products.Models
{
    public class ProductStockModel
    {
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public SizeEnum Size { get; set; }
        public string Color { get; set; }
    }
}
