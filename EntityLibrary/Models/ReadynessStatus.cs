﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLibrary.Models
{
	[Table("ReadynessStatuses")]
    public class ReadynessStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        //
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
