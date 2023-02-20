using System.ComponentModel.DataAnnotations.Schema;

namespace StockControlProject.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short? Stock { get; set; }
        public DateTime? ExpiredDate { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public Product()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}
