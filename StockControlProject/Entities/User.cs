using StockControlProject.Domain.Enums;

namespace StockControlProject.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Orders = new List<Order>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhotoURL { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public UserRole Role { get; set; }
        public string Password { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
