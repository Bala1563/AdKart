using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}