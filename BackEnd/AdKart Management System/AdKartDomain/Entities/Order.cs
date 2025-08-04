using AdKartShared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    public class Order : BaseEntity
    {
        [Required]
        public Guid CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        [Required]
        public decimal CoinsUsed { get; set; }

        public decimal Amount { get; set; }
    }
}