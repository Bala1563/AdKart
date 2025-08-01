using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    [Table("Town")]
    public class Town : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}