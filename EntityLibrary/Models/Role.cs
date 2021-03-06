using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLibrary.Models
{
    [Serializable]
	[Table("Roles")]
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        //
        public virtual IEnumerable<Account> Accounts { get; set; }
        public Role() { }
    }
}
