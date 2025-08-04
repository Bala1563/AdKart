using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    public class AdWatch : BaseEntity
    {
        [Required]
        public Guid AdId { get; set; }

        [ForeignKey(nameof(AdId))]
        public Advertisement Advertisement { get; set; }

        public decimal RewardGiven { get; set; }
    }
}