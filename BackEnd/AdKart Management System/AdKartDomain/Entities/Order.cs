using AdKartShared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    public class Order : BaseEntity
    {
        [Required]
        public Guid ShopId { get; set; }

        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        [Required]
        public decimal CoinsUsed { get; set; }

        public decimal Amount { get; set; }

        // Navigation Property
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}