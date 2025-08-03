using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    [Table("Shop")]
    public class Shop : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public string Address { get; set; }

        public string MapsLink { get; set; }

        [Required, StringLength(10)]
        public string PhoneNumber { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        [Required]
        public string ReferralCode { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public User Owner { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}