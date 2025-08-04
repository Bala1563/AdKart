using System.ComponentModel.DataAnnotations;

namespace AdKartDomain.Entities
{
    public class Advertisement : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required, MaxLength(50)]
        public string AdvertiserName { get; set; }

        [Required, StringLength(10)]
        public string AdvertiserPhoneNumber { get; set; }

        [Required]
        public string ContentUrl { get; set; }

        [Required]
        public decimal CoinsPerDay { get; set; }

        [Required]
        public DateTime FromDate { get; set; }

        [Required]
        public DateTime ToDate { get; set; }

        [MaxLength(50)]
        public string AgentName { get; set; }
    }
}