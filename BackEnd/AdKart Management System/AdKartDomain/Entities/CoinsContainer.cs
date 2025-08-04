using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    public class CoinsContainer : BaseEntity
    {
        [Required]
        public Guid TownId { get; set; }

        [ForeignKey(nameof(TownId))]
        public Town Town { get; set; }

        [Required]
        public decimal Coins { get; set; }
    }
}