using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdKartDomain.Entities
{
    [Table("[User]")]
    public class User : BaseEntity
    {

        [Required, MaxLength(25)]
        public string FirstName { get; set; }

        [Required, MaxLength(25)]
        public string LastName { get; set; }

        [Required, MaxLength(100)]
        public string Address { get; set; }

        public Guid TownId { get; set; }

        [ForeignKey(nameof(TownId))]
        public Town Town { get; set; }

        [Required, StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public Guid UserRoleId { get; set; }

        [ForeignKey(nameof(UserRoleId))]
        public UserRole UserRole { get; set; }

        [Required]
        public string ProfilePic { get; set; }

        [Required]
        public int Coins { get; set; }
    }
}