using AdKartShared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public Guid ShopId { get; set; }

        [ForeignKey(nameof(ShopId))]
        public Shop Shop { get; set; }

        public Decimal Price { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public MeasuringType MeasuringType { get; set; }
    }
}