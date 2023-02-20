using Microsoft.EntityFrameworkCore;
using StockControlProject.Domain.Entities;

namespace StockControlProject.Repository.Context
{
    public class StockControlContext : DbContext
    {
        public StockControlContext(DbContextOptions<StockControlContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=***;Database=***;Uid=***;Pwd=***;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
