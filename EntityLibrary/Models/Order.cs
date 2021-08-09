using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLibrary
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

        [ForeignKey(nameof(EntityLibrary.ReadynessStatus))]
        public int StatusId { get; set; }
        public ReadynessStatus ReadynessStatus { get; set; }

        [ForeignKey(nameof(Account))]
        public int OwnerAccountId { get; set; }
        public Account OwnerAccount { get; set; }

        [ForeignKey(nameof(Account))]
        public int EmployeeAccountId { get; set; }
        public Account EmployeeAccount { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Pirce { get; set; }

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
