using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLibrary.Models
{
    [Serializable]
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

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

		public ICollection<Order> EmployeeAccountOrders { get; set; }
		public ICollection<Order> OwnerAccountOrders { get; set; }
        public ICollection<Message> FromMessages { get; set; }
        public ICollection<Message> ToMessages { get; set; }

        public Account() { }
	}
}
