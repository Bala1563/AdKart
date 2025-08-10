using AdKartShared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    public class Cart : BaseEntity
    {
        [Required]
        public Guid ShopId { get; set; }

        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }

        [Required]
        public CartStatus Status { get; set; }

        // Navigation Property
        public ICollection<CartItem> CartItems { get; set; }
    }
}