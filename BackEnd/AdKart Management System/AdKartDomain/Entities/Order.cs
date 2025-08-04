using AdKartShared.Enums;
using System.ComponentModel.DataAnnotations;

namespace AdKartDomain.Entities
{
    public class Order : BaseEntity
    {
        [Required]
        public OrderStatus Status { get; set; }

        [Required]
        public decimal CoinsUsed { get; set; }

        public decimal Amount { get; set; }
    }
}