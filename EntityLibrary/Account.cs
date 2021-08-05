using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLibrary
{
    [Table("Accounts")]
	public class Account
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [ForeignKey(nameof(EntityLibrary.Role))]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
