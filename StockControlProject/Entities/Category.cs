namespace StockControlProject.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
