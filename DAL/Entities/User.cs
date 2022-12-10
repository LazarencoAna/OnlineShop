namespace OnlineShop.DAL.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public virtual List<FavoriteProduct> FavoriteProducts { get; set; }
    }
}
