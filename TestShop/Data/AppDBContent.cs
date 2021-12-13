using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data {
    public class AppDBContent : DbContext {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {
        }

        public DbSet<Car> Car { get; }

        public DbSet<Category> Category { get;  }
        public DbSet<ShopCartItem> ShopCartItem { get; }
        public DbSet<Order> Order { get; }
        public DbSet<OrderDetail> OrderDetail { get; }
    }
}