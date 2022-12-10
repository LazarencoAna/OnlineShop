namespace OnlineShop.DAL.Entities
{
    public class ProductCart
    {
        public int ProductCartId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
