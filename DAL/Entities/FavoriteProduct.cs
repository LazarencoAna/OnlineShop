namespace OnlineShop.DAL.Entities
{
    public class FavoriteProduct
    {
        public int FavoriteProductId { get; set; }
        public string Userid { get; set; }
        public int ProductId { get; set; }
    }
}
