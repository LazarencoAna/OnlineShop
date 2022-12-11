namespace OnlineShop.DAL.Entities
{
    public class User
    {
        public string UserId { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
