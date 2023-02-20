using System.ComponentModel.DataAnnotations.Schema;

namespace StockControlProject.Domain.Entities
{
    public class BaseEntity
    {
        [Column(Order = 1)]
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
