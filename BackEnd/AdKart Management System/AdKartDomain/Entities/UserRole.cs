using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    [Table("UserRole")]
    public class UserRole : BaseEntity
    {
        [Required]
        public string Role { get; set; }
    }
}