namespace OnlineShop.DAL.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserAccountId { get; set; }
        public DateTime Created { get; set; }

        public virtual UserAccount User { get; set; }
        public virtual Product Product { get; set; }
    }
}
