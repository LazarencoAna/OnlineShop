namespace OnlineShop.DAL.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime Created { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
