﻿namespace OnlineShop.DAL.Entities
{
    public class ProductOrder
    {
        public int ProductOrderId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Size { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
