using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLibrary.Models
{
	[Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(250)]
        public string DescriptionOfProblem { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; } // initialized when constructed

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Deadline { get; set; }

        [ForeignKey("ReadynessStatus")]
        public int StatusId { get; set; }
        public virtual ReadynessStatus ReadynessStatus { get; set; }

        [ForeignKey("Account")]
        public int OwnAccountId { get; set; }

        [ForeignKey("Account")]
        public int EmpAccountId { get; set; }
        
        public virtual Account Account { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(250)]
        public string Feedback { get; set; }

        //
        public virtual IEnumerable<SolvedProblemType> SolvedProblemTypes { get; set; }

        public Order()
        {
            CreationDate = DateTime.Now;
        }
    }
}
