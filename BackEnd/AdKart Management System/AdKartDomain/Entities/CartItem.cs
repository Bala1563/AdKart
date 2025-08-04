using AdKartShared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    public class CartItem : BaseEntity
    {
        [Required]
        public Guid CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public decimal Quantity { get; set; }

        public int NumberOfItems { get; set; }

        [Required]
        public CartItemStatus Status { get; set; }

        public decimal Price { get; set; }
    }
}