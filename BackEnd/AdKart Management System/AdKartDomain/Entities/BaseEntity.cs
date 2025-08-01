using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        [ForeignKey(nameof(CreatedByUser))]
        public Guid? CreatedBy { get; set; }

        [ForeignKey(nameof(UpdatedByUser))]
        public Guid? UpdatedBy { get; set; }

        // Navigation
        public User CreatedByUser { get; set; }

        public User UpdatedByUser { get; set; }
    }
}