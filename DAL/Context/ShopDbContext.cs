﻿using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Entities;

namespace OnlineShop.DAL.Context
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DeliveryType> DeliveryTypes { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductDeliveryMethod> ProductDeliveryMethods { get; set; }

        public string DbPath { get; }
        public ShopDbContext(DbContextOptions<ShopDbContext> dbContext) : base(dbContext)
        {
        }

    }
}