using System.ComponentModel.DataAnnotations.Schema;

namespace StockControlProject.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
