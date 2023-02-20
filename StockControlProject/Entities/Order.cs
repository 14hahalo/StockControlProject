using StockControlProject.Domain.Enums;

namespace StockControlProject.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public int UserID { get; set; }
        public Status Status { get; set; }
        public virtual User? User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
